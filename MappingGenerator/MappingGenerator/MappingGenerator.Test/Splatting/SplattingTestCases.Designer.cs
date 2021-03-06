﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MappingGenerator.Test.Splatting {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class SplattingTestCases {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SplattingTestCases() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MappingGenerator.Test.Splatting.SplattingTestCases", typeof(SplattingTestCases).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.Collections.Generic;
        ///using System.Text;
        ///
        ///namespace MappingGenerator.Test.Splatting.TestCaseData
        ///{
        ///    class TestMapper
        ///    {
        ///        public void DoSomething()
        ///        {
        ///            var user = new UserDTO();
        ///            ProceessUser([|user|]);
        ///        }
        ///
        ///        public void ProceessUser(string firstName, string lastName, int age)
        ///        {
        ///
        ///        }
        ///    }
        ///
        ///
        ///    public class UserDTO
        ///    {
        ///        public string FirstName { get; set; }
        ///        public string La [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string _001_SplattingInMethodInvocation {
            get {
                return ResourceManager.GetString("_001_SplattingInMethodInvocation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.Collections.Generic;
        ///using System.Text;
        ///
        ///namespace MappingGenerator.Test.Splatting.TestCaseData
        ///{
        ///    class TestMapper
        ///    {
        ///        public void DoSomething()
        ///        {
        ///            var user = new UserDTO();
        ///            ProceessUser(user.FirstName, user.LastName, user.Age);
        ///        }
        ///
        ///        public void ProceessUser(string firstName, string lastName, int age)
        ///        {
        ///
        ///        }
        ///    }
        ///
        ///
        ///    public class UserDTO
        ///    {
        ///        public string FirstName { get; s [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string _001_SplattingInMethodInvocation_FIXED {
            get {
                return ResourceManager.GetString("_001_SplattingInMethodInvocation_FIXED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.Collections.Generic;
        ///using System.Text;
        ///
        ///namespace MappingGenerator.Test.Splatting.TestCaseData
        ///{
        ///    class TestMapper
        ///    {
        ///        public void DoSomething()
        ///        {
        ///            var user = new UserDTO();
        ///            ProceessUser(firstName: user.FirstName, lastName: user.LastName, age: user.Age);
        ///        }
        ///
        ///        public void ProceessUser(string firstName, string lastName, int age)
        ///        {
        ///
        ///        }
        ///    }
        ///
        ///
        ///    public class UserDTO
        ///    {
        ///        public [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string _001_SplattingInMethodInvocationWithNamedParameters_FIXED {
            get {
                return ResourceManager.GetString("_001_SplattingInMethodInvocationWithNamedParameters_FIXED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.Collections.Generic;
        ///using System.Text;
        ///
        ///namespace MappingGenerator.Test.Splatting.TestCaseData
        ///{
        ///    class TestMapper
        ///    {
        ///        public void DoSomething()
        ///        {
        ///            var user = new UserDTO();
        ///            new SampleClass(user);
        ///        }
        ///    }
        ///
        ///    public class SampleClass
        ///    {
        ///        public SampleClass(string firstName, string lastName, int age)
        ///        {
        ///
        ///        }
        ///    }
        ///
        ///
        ///    public class UserDTO
        ///    {
        ///        public string FirstName {  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string _002_SplattingInConstructorInvocation {
            get {
                return ResourceManager.GetString("_002_SplattingInConstructorInvocation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.Collections.Generic;
        ///using System.Text;
        ///
        ///namespace MappingGenerator.Test.Splatting.TestCaseData
        ///{
        ///    class TestMapper
        ///    {
        ///        public void DoSomething()
        ///        {
        ///            var user = new UserDTO();
        ///            new SampleClass(user.FirstName, user.LastName, user.Age);
        ///        }
        ///    }
        ///
        ///    public class SampleClass
        ///    {
        ///        public SampleClass(string firstName, string lastName, int age)
        ///        {
        ///
        ///        }
        ///    }
        ///
        ///
        ///    public class UserDTO
        ///    {        /// [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string _002_SplattingInConstructorInvocation_FIXED {
            get {
                return ResourceManager.GetString("_002_SplattingInConstructorInvocation_FIXED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.Collections.Generic;
        ///using System.Text;
        ///
        ///namespace MappingGenerator.Test.Splatting.TestCaseData
        ///{
        ///    class TestMapper
        ///    {
        ///        public void DoSomething()
        ///        {
        ///            var user = new UserDTO();
        ///            new SampleClass(firstName: user.FirstName, lastName: user.LastName, age: user.Age);
        ///        }
        ///    }
        ///
        ///    public class SampleClass
        ///    {
        ///        public SampleClass(string firstName, string lastName, int age)
        ///        {
        ///
        ///        }
        ///    }
        ///
        ///
        ///    pu [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string _002_SplattingInConstructorInvocationWithNamedParameters_FIXED {
            get {
                return ResourceManager.GetString("_002_SplattingInConstructorInvocationWithNamedParameters_FIXED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.Collections.Generic;
        ///using System.Text;
        ///
        ///namespace MappingGenerator.Test.Splatting.TestCaseData
        ///{
        ///    class TestMapper
        ///    {
        ///        public void DoSomething()
        ///        {
        ///            var user = new UserDTO();
        ///            UserProcessor.ProceessUser(user);
        ///        }
        ///
        ///        public void ProceessUser(string firstName, string lastName, int age)
        ///        {
        ///
        ///        }
        ///    }
        ///
        ///    public class UserProcessor
        ///    {
        ///        public void ProceessUser(string firstName, string [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string _003_SplattingWithBestOverloadMatch {
            get {
                return ResourceManager.GetString("_003_SplattingWithBestOverloadMatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.Collections.Generic;
        ///using System.Text;
        ///
        ///namespace MappingGenerator.Test.Splatting.TestCaseData
        ///{
        ///    class TestMapper
        ///    {
        ///        public void DoSomething()
        ///        {
        ///            var user = new UserDTO();
        ///            UserProcessor.ProceessUser(firstName: user.FirstName, lastName: user.LastName, age: user.Age);
        ///        }
        ///
        ///        public void ProceessUser(string firstName, string lastName, int age)
        ///        {
        ///
        ///        }
        ///    }
        ///
        ///    public class UserProcessor
        ///    [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string _003_SplattingWithBestOverloadMatch_FIXED {
            get {
                return ResourceManager.GetString("_003_SplattingWithBestOverloadMatch_FIXED", resourceCulture);
            }
        }
    }
}
