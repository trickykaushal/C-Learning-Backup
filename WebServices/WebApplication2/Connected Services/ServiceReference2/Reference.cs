﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication2.ServiceReference2 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference2.NewWebServiceSoap")]
    public interface NewWebServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddTwo", ReplyAction="*")]
        int AddTwo(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddTwo", ReplyAction="*")]
        System.Threading.Tasks.Task<int> AddTwoAsync(int a, int b);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface NewWebServiceSoapChannel : WebApplication2.ServiceReference2.NewWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class NewWebServiceSoapClient : System.ServiceModel.ClientBase<WebApplication2.ServiceReference2.NewWebServiceSoap>, WebApplication2.ServiceReference2.NewWebServiceSoap {
        
        public NewWebServiceSoapClient() {
        }
        
        public NewWebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public NewWebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NewWebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NewWebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int AddTwo(int a, int b) {
            return base.Channel.AddTwo(a, b);
        }
        
        public System.Threading.Tasks.Task<int> AddTwoAsync(int a, int b) {
            return base.Channel.AddTwoAsync(a, b);
        }
    }
}