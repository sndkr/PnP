﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Governance.TimerJobs.Policy {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class SitePolicyResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SitePolicyResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Governance.TimerJobs.Policy.SitePolicyResources", typeof(SitePolicyResources).Assembly);
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
        ///   Looks up a localized string similar to HBI.
        /// </summary>
        internal static string BusinessImpact_HBI {
            get {
                return ResourceManager.GetString("BusinessImpact_HBI", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to LBI.
        /// </summary>
        internal static string BusinessImpact_LBI {
            get {
                return ResourceManager.GetString("BusinessImpact_LBI", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to MBI.
        /// </summary>
        internal static string BusinessImpact_MBI {
            get {
                return ResourceManager.GetString("BusinessImpact_MBI", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to NDA.
        /// </summary>
        internal static string BusinessImpact_NDA {
            get {
                return ResourceManager.GetString("BusinessImpact_NDA", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your SharePoint site has expired because the site collection information was not updated. This site has been locked for more than 30 days and will be deleted on {0} ,If you or your users still need this site, you can unlock it before it is deleted..
        /// </summary>
        internal static string MailBodyDelete {
            get {
                return ResourceManager.GetString("MailBodyDelete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to First Notice: Please update your site before {0}, or your site will be locked and all users will be unable to access the site. All locked sites will be deleted after 90 days..
        /// </summary>
        internal static string MailBodyFirstLock {
            get {
                return ResourceManager.GetString("MailBodyFirstLock", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Second Notice: Please update your site before {0}, or your site will be locked and all users will be unable to access the site. All locked sites will be deleted after 90 days..
        /// </summary>
        internal static string MailBodySecondLock {
            get {
                return ResourceManager.GetString("MailBodySecondLock", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your SharePoint site has expired and will be deleted: {0}.
        /// </summary>
        internal static string MailSubjectDelete {
            get {
                return ResourceManager.GetString("MailSubjectDelete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Update your SharePoint site information: {0}.
        /// </summary>
        internal static string MailSubjectFirstLock {
            get {
                return ResourceManager.GetString("MailSubjectFirstLock", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Update your SharePoint site information - second notice: {0}.
        /// </summary>
        internal static string MailSubjectSecondLock {
            get {
                return ResourceManager.GetString("MailSubjectSecondLock", resourceCulture);
            }
        }
    }
}
