﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Interfell.Store.Module.Commons.Resources {
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
    public class General {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal General() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Interfell.Store.Module.Commons.Resources.General", typeof(General).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Usuario o contraseña invalido..
        /// </summary>
        public static string Invalid_Authentication {
            get {
                return ResourceManager.GetString("Invalid_Authentication", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Usuario NO habilitado, contácte al administrador..
        /// </summary>
        public static string Not_Authorized {
            get {
                return ResourceManager.GetString("Not_Authorized", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Nombre de usuario no existe.
        /// </summary>
        public static string Not_Find_User {
            get {
                return ResourceManager.GetString("Not_Find_User", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to El correo electrónico ya se encuentra registrado..
        /// </summary>
        public static string Not_Repeat_Email {
            get {
                return ResourceManager.GetString("Not_Repeat_Email", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Operación incorrecta.
        /// </summary>
        public static string OperationIssue {
            get {
                return ResourceManager.GetString("OperationIssue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Operación correcta.
        /// </summary>
        public static string OperationSucsess {
            get {
                return ResourceManager.GetString("OperationSucsess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error.
        /// </summary>
        public static string Title_Error {
            get {
                return ResourceManager.GetString("Title_Error", resourceCulture);
            }
        }
    }
}
