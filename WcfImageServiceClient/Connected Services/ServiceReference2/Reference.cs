﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfImageServiceClient.ServiceReference2 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference2.ICallback", CallbackContract=typeof(WcfImageServiceClient.ServiceReference2.ICallbackCallback), SessionMode=System.ServiceModel.SessionMode.Required)]
    public interface ICallback {
        
        // CODEGEN: Trwa generowanie kontraktu komunikatu, ponieważ nazwa otoki (ImageNameMessage) komunikatu ImageNameMessage nie pasuje do domyślnej wartości (createDescription).
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICallback/createDescription")]
        void createDescription(WcfImageServiceClient.ServiceReference2.ImageNameMessage request);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICallback/createDescription")]
        System.Threading.Tasks.Task createDescriptionAsync(WcfImageServiceClient.ServiceReference2.ImageNameMessage request);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICallbackCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICallback/createDescriptionCallback")]
        void createDescriptionCallback();
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ImageNameMessage", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ImageNameMessage {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public string name;
        
        public ImageNameMessage() {
        }
        
        public ImageNameMessage(string name) {
            this.name = name;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICallbackChannel : WcfImageServiceClient.ServiceReference2.ICallback, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CallbackClient : System.ServiceModel.DuplexClientBase<WcfImageServiceClient.ServiceReference2.ICallback>, WcfImageServiceClient.ServiceReference2.ICallback {
        
        public CallbackClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public CallbackClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public CallbackClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public CallbackClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public CallbackClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        void WcfImageServiceClient.ServiceReference2.ICallback.createDescription(WcfImageServiceClient.ServiceReference2.ImageNameMessage request) {
            base.Channel.createDescription(request);
        }
        
        public void createDescription(string name) {
            WcfImageServiceClient.ServiceReference2.ImageNameMessage inValue = new WcfImageServiceClient.ServiceReference2.ImageNameMessage();
            inValue.name = name;
            ((WcfImageServiceClient.ServiceReference2.ICallback)(this)).createDescription(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task WcfImageServiceClient.ServiceReference2.ICallback.createDescriptionAsync(WcfImageServiceClient.ServiceReference2.ImageNameMessage request) {
            return base.Channel.createDescriptionAsync(request);
        }
        
        public System.Threading.Tasks.Task createDescriptionAsync(string name) {
            WcfImageServiceClient.ServiceReference2.ImageNameMessage inValue = new WcfImageServiceClient.ServiceReference2.ImageNameMessage();
            inValue.name = name;
            return ((WcfImageServiceClient.ServiceReference2.ICallback)(this)).createDescriptionAsync(inValue);
        }
    }
}
