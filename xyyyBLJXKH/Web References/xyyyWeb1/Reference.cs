﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

// 
// 此源代码是由 Microsoft.VSDesigner 4.0.30319.42000 版自动生成。
// 
#pragma warning disable 1591

namespace xyyyBLJXKH.xyyyWeb1 {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="DHCC-Ris-XiangYaOneSoap", Namespace="http://tempuri.org")]
    public partial class DHCCRisXiangYaOne : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback DhcServiceOperationCompleted;
        
        private System.Threading.SendOrPostCallback TestByLiyOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public DHCCRisXiangYaOne() {
            this.Url = "http://192.168.2.64/csp/dhcens/DHC.Ris.XiangYaOne.BS.Web.cls";
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event DhcServiceCompletedEventHandler DhcServiceCompleted;
        
        /// <remarks/>
        public event TestByLiyCompletedEventHandler TestByLiyCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/DHC.Ris.XiangYaOne.BS.Web.DhcService", RequestNamespace="http://tempuri.org", ResponseNamespace="http://tempuri.org", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string DhcService(string funName, string pInput) {
            object[] results = this.Invoke("DhcService", new object[] {
                        funName,
                        pInput});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void DhcServiceAsync(string funName, string pInput) {
            this.DhcServiceAsync(funName, pInput, null);
        }
        
        /// <remarks/>
        public void DhcServiceAsync(string funName, string pInput, object userState) {
            if ((this.DhcServiceOperationCompleted == null)) {
                this.DhcServiceOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDhcServiceOperationCompleted);
            }
            this.InvokeAsync("DhcService", new object[] {
                        funName,
                        pInput}, this.DhcServiceOperationCompleted, userState);
        }
        
        private void OnDhcServiceOperationCompleted(object arg) {
            if ((this.DhcServiceCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DhcServiceCompleted(this, new DhcServiceCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/DHC.Ris.XiangYaOne.BS.Web.TestByLiy", RequestNamespace="http://tempuri.org", ResponseNamespace="http://tempuri.org", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string TestByLiy(string TestInput) {
            object[] results = this.Invoke("TestByLiy", new object[] {
                        TestInput});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void TestByLiyAsync(string TestInput) {
            this.TestByLiyAsync(TestInput, null);
        }
        
        /// <remarks/>
        public void TestByLiyAsync(string TestInput, object userState) {
            if ((this.TestByLiyOperationCompleted == null)) {
                this.TestByLiyOperationCompleted = new System.Threading.SendOrPostCallback(this.OnTestByLiyOperationCompleted);
            }
            this.InvokeAsync("TestByLiy", new object[] {
                        TestInput}, this.TestByLiyOperationCompleted, userState);
        }
        
        private void OnTestByLiyOperationCompleted(object arg) {
            if ((this.TestByLiyCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.TestByLiyCompleted(this, new TestByLiyCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void DhcServiceCompletedEventHandler(object sender, DhcServiceCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DhcServiceCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal DhcServiceCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void TestByLiyCompletedEventHandler(object sender, TestByLiyCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TestByLiyCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal TestByLiyCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591