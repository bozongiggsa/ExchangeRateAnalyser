﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExchangeRateAnalyser {
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
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ExchangeRateAnalyser.Strings", typeof(Strings).Assembly);
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
        ///   Looks up a localized string similar to It was not possible to detect best currency. Please, change the initial parameters or try again later..
        /// </summary>
        internal static string ErrorBestCurrencyNull {
            get {
                return ResourceManager.GetString("ErrorBestCurrencyNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The final capital value is not in permissible range. Please try smaller initial capital amount..
        /// </summary>
        internal static string ErrorCapitalIsNotInRange {
            get {
                return ResourceManager.GetString("ErrorCapitalIsNotInRange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to End date can&apos;t be greater than today.
        /// </summary>
        internal static string ErrorEndDateGreaterThanToday {
            get {
                return ResourceManager.GetString("ErrorEndDateGreaterThanToday", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Initial capital should be positive number.
        /// </summary>
        internal static string ErrorInitialCapitalNegative {
            get {
                return ResourceManager.GetString("ErrorInitialCapitalNegative", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Initial capital can&apos;t be greater than 79 228 162 514 264 337 593 543 950 335.
        /// </summary>
        internal static string ErrorInitialCapitalTooBig {
            get {
                return ResourceManager.GetString("ErrorInitialCapitalTooBig", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occured during saving xml file with the result set..
        /// </summary>
        internal static string ErrorIOResultFileWriteFailed {
            get {
                return ResourceManager.GetString("ErrorIOResultFileWriteFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occured during the proccessing the data..
        /// </summary>
        internal static string ErrorOccured {
            get {
                return ResourceManager.GetString("ErrorOccured", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occured during the proccessing the data. Please, try again later..
        /// </summary>
        internal static string ErrorOccuredTryLater {
            get {
                return ResourceManager.GetString("ErrorOccuredTryLater", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Start date can&apos;t be greater than today.
        /// </summary>
        internal static string ErrorStartDateGreaterThanToday {
            get {
                return ResourceManager.GetString("ErrorStartDateGreaterThanToday", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Start date can&apos;t be greater than End Date.
        /// </summary>
        internal static string ErrorStatDateGreaterThanEndDate {
            get {
                return ResourceManager.GetString("ErrorStatDateGreaterThanEndDate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value is not in permissible range..
        /// </summary>
        internal static string ErrorValueIsNotInRange {
            get {
                return ResourceManager.GetString("ErrorValueIsNotInRange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There was a problem connecting to the remote data source. Please, try again later.
        /// </summary>
        internal static string ErrorWebException {
            get {
                return ResourceManager.GetString("ErrorWebException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Analysis has been completed successfully.
        /// </summary>
        internal static string InfoAnalysisCompleted {
            get {
                return ResourceManager.GetString("InfoAnalysisCompleted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please enter valid end date. Format is yyyy-mm-dd:.
        /// </summary>
        internal static string InfoEnterValidEndDate {
            get {
                return ResourceManager.GetString("InfoEnterValidEndDate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please enter valid initial capital (positive number):.
        /// </summary>
        internal static string InfoEnterValidInitialCapital {
            get {
                return ResourceManager.GetString("InfoEnterValidInitialCapital", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please enter valid start date. Format is yyyy-mm-dd:.
        /// </summary>
        internal static string InfoEnterValidStartDate {
            get {
                return ResourceManager.GetString("InfoEnterValidStartDate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please see the analysis result below..
        /// </summary>
        internal static string InfoSeeResultSet {
            get {
                return ResourceManager.GetString("InfoSeeResultSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Started analysis with parameters: start date = {0}, end date = {1}, initial capital = {2} rub.
        /// </summary>
        internal static string InfoStartedWithParameters {
            get {
                return ResourceManager.GetString("InfoStartedWithParameters", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Warning: There is no profitable combination within these start and end dates. Please see information on the currency with less possible exchange losses..
        /// </summary>
        internal static string WarningNoProfit {
            get {
                return ResourceManager.GetString("WarningNoProfit", resourceCulture);
            }
        }
    }
}
