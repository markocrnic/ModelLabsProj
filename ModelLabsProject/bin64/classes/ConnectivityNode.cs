//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FTN {
    using System;
    using FTN;
    
    
    /// Connectivity nodes are points where terminals of conducting equipment are connected together with zero impedance.
    public class ConnectivityNode : IdentifiedObject {
        
        private string cim_description;
        
        private const bool isDescriptionMandatory = true;
        
        private const string _descriptionPrefix = "cim";
        
        public virtual string Description {
            get {
                return this.cim_description;
            }
            set {
                this.cim_description = value;
            }
        }
        
        public virtual bool DescriptionHasValue {
            get {
                return this.cim_description != null;
            }
        }
        
        public static bool IsDescriptionMandatory {
            get {
                return isDescriptionMandatory;
            }
        }
        
        public static string DescriptionPrefix {
            get {
                return _descriptionPrefix;
            }
        }
    }
}
