﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowApp.GradeService {
    using System.Data;
    using CommonClasses;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="GradeService.WebServiceSoap")]
    public interface WebServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string HelloWorld();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<string> HelloWorldAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/addStudent", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool addStudent(string fname, string lname);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/addStudent", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> addStudentAsync(string fname, string lname);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/addMultipleStudents", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void addMultipleStudents(CommonClasses.Students[] students);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/addMultipleStudents", ReplyAction="*")]
        System.Threading.Tasks.Task addMultipleStudentsAsync(CommonClasses.Students[] students);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/addAssesment", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool addAssesment(string type, string date, string marks);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/addAssesment", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> addAssesmentAsync(string type, string date, string marks);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/addmarks", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void addmarks(CommonClasses.Students[] students, string assesid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/addmarks", ReplyAction="*")]
        System.Threading.Tasks.Task addmarksAsync(CommonClasses.Students[] students, string assesid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getGrade", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable getGrade();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getGrade", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> getGradeAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getSheet", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable getSheet();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getSheet", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> getSheetAsync();
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.79.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Students : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string idField;
        
        private string fnameField;
        
        private string lnameField;
        
        private string marksField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("Id");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Fname {
            get {
                return this.fnameField;
            }
            set {
                this.fnameField = value;
                this.RaisePropertyChanged("Fname");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Lname {
            get {
                return this.lnameField;
            }
            set {
                this.lnameField = value;
                this.RaisePropertyChanged("Lname");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string Marks {
            get {
                return this.marksField;
            }
            set {
                this.marksField = value;
                this.RaisePropertyChanged("Marks");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceSoapChannel : WindowApp.GradeService.WebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceSoapClient : System.ServiceModel.ClientBase<WindowApp.GradeService.WebServiceSoap>, WindowApp.GradeService.WebServiceSoap {
        
        public WebServiceSoapClient() {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string HelloWorld() {
            return base.Channel.HelloWorld();
        }
        
        public System.Threading.Tasks.Task<string> HelloWorldAsync() {
            return base.Channel.HelloWorldAsync();
        }
        
        public bool addStudent(string fname, string lname) {
            return base.Channel.addStudent(fname, lname);
        }
        
        public System.Threading.Tasks.Task<bool> addStudentAsync(string fname, string lname) {
            return base.Channel.addStudentAsync(fname, lname);
        }
        
        public void addMultipleStudents(CommonClasses.Students[] students) {
            base.Channel.addMultipleStudents(students);
        }
        
        public System.Threading.Tasks.Task addMultipleStudentsAsync(CommonClasses.Students[] students) {
            return base.Channel.addMultipleStudentsAsync(students);
        }
        
        public bool addAssesment(string type, string date, string marks) {
            return base.Channel.addAssesment(type, date, marks);
        }
        
        public System.Threading.Tasks.Task<bool> addAssesmentAsync(string type, string date, string marks) {
            return base.Channel.addAssesmentAsync(type, date, marks);
        }
        
        public void addmarks(CommonClasses.Students[] students, string assesid) {
            base.Channel.addmarks(students, assesid);
        }
        
        public System.Threading.Tasks.Task addmarksAsync(CommonClasses.Students[] students, string assesid) {
            return base.Channel.addmarksAsync(students, assesid);
        }
        
        public System.Data.DataTable getGrade() {
            return base.Channel.getGrade();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> getGradeAsync() {
            return base.Channel.getGradeAsync();
        }
        
        public System.Data.DataTable getSheet() {
            return base.Channel.getSheet();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> getSheetAsync() {
            return base.Channel.getSheetAsync();
        }
    }
}