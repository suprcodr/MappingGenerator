﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MappingGenerator.Mappings;
using MappingGenerator.Mappings.SourceFinders;
using MappingGenerator.MethodHelpers;
using MappingGenerator.RoslynHelpers;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Completion;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Editing;

namespace MappingGenerator.Features.Suggestions
{
    [ExportCompletionProvider(nameof(MethodParametersSuggestionProvider), LanguageNames.CSharp)]
    public class MethodParametersSuggestionProvider : CompletionProvider
    {
        private readonly CompletionItemRules preselectCompletionRules;

        private static readonly HashSet<SymbolKind> AllowedSymbolsForCompletion = new HashSet<SymbolKind>
        {
            SymbolKind.Parameter,
            SymbolKind.Local,
            SymbolKind.Field,
            SymbolKind.Property
        };

        public MethodParametersSuggestionProvider()
        {
            preselectCompletionRules = CompletionItemRules.Default.WithMatchPriority(MatchPriority.Preselect).WithSelectionBehavior(CompletionItemSelectionBehavior.SoftSelection);
        }

        public override async Task ProvideCompletionsAsync(CompletionContext context)
        {
            if (!context.Document.SupportsSemanticModel) return;

            var syntaxRoot = await context.Document.GetSyntaxRootAsync();
            var semanticModel = await context.Document.GetSemanticModelAsync();

            var tokenAtCursor = SuggestionHelpers.GetCurrentArgumentListSyntaxToken(syntaxRoot, context.Position);
            if (!tokenAtCursor.IsKind(SyntaxKind.OpenParenToken)) return;

            var callbackArgumentList = tokenAtCursor.Parent as ArgumentListSyntax;
            
            if (callbackArgumentList==null || callbackArgumentList.Arguments.Any()) return;

            var expression = callbackArgumentList.Parent.FindNearestContainer<InvocationExpressionSyntax, ObjectCreationExpressionSyntax>();
            if (expression != null)
            {
                if (expression is InvocationExpressionSyntax invocationExpression)
                {
                    if (invocationExpression.ArgumentList.Arguments.Count == 0)
                    {
                        var invocation = new MethodInvocation(invocationExpression);
                        SuggestMethodParameters(context, invocation, semanticModel);
                    }
                }
                else if (expression is ObjectCreationExpressionSyntax creationExpression)
                {
                    if (creationExpression.ArgumentList?.Arguments.Count == 0)
                    {
                        var invocation = new ConstructorInvocation(creationExpression);
                        SuggestMethodParameters(context, invocation, semanticModel);
                    }
                }
            }
        }

        private void SuggestMethodParameters(CompletionContext context, IInvocation invocation, SemanticModel semanticModel)
        {
            var argumentList = GetArgumentListWithLocalVariables(context.Document, invocation, false, semanticModel);
            if (argumentList != null)
            {
                context.AddItem(CompletionItem.Create(argumentList, rules: preselectCompletionRules));
            }

            var argumentListWithParameterNames = GetArgumentListWithLocalVariables(context.Document, invocation, true, semanticModel);
            if (argumentListWithParameterNames != null)
            {
                context.AddItem(CompletionItem.Create(argumentListWithParameterNames, rules: preselectCompletionRules));
            }
        }

        private string GetArgumentListWithLocalVariables(Document document, IInvocation invocation, bool generateNamedParameters, SemanticModel semanticModel)
        {
            var mappingSourceFinder = LocalScopeMappingSourceFinder.FromScope(semanticModel, invocation.SourceNode, AllowedSymbolsForCompletion);
            mappingSourceFinder.AllowMatchOnlyByTypeWhenSingleCandidate = true;

            var syntaxGenerator = SyntaxGenerator.GetGenerator(document);
            var overloadParameterSets = invocation.GetOverloadParameterSets(semanticModel);
            if (overloadParameterSets != null)
            {
                var contextAssembly = semanticModel.FindContextAssembly(invocation.SourceNode);
                var mappingEngine = new MappingEngine(semanticModel, syntaxGenerator, contextAssembly);
                var parametersMatch = MethodHelper.FindBestParametersMatch(mappingSourceFinder, overloadParameterSets);
                if (parametersMatch != null)
                {
                    var argumentList = parametersMatch.ToArgumentListSyntax(mappingEngine, generateNamedParameters);
                    var chunks = argumentList.Arguments.Select(a => a.ToString());
                    return string.Join(", ", chunks);
                }
            }

            return null;
        }
    }
}
