﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApp.SW_Soap {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SW_Soap.SW_PruebaSoap")]
    public interface SW_PruebaSoap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento GetConectResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetConect", ReplyAction="*")]
        WebApp.SW_Soap.GetConectResponse GetConect(WebApp.SW_Soap.GetConectRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetConect", ReplyAction="*")]
        System.Threading.Tasks.Task<WebApp.SW_Soap.GetConectResponse> GetConectAsync(WebApp.SW_Soap.GetConectRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento Nombres del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CreateEmpl", ReplyAction="*")]
        WebApp.SW_Soap.CreateEmplResponse CreateEmpl(WebApp.SW_Soap.CreateEmplRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CreateEmpl", ReplyAction="*")]
        System.Threading.Tasks.Task<WebApp.SW_Soap.CreateEmplResponse> CreateEmplAsync(WebApp.SW_Soap.CreateEmplRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento GetAllEmplResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAllEmpl", ReplyAction="*")]
        WebApp.SW_Soap.GetAllEmplResponse GetAllEmpl(WebApp.SW_Soap.GetAllEmplRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAllEmpl", ReplyAction="*")]
        System.Threading.Tasks.Task<WebApp.SW_Soap.GetAllEmplResponse> GetAllEmplAsync(WebApp.SW_Soap.GetAllEmplRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento GetEmplResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetEmpl", ReplyAction="*")]
        WebApp.SW_Soap.GetEmplResponse GetEmpl(WebApp.SW_Soap.GetEmplRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetEmpl", ReplyAction="*")]
        System.Threading.Tasks.Task<WebApp.SW_Soap.GetEmplResponse> GetEmplAsync(WebApp.SW_Soap.GetEmplRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento GetVincResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetVinc", ReplyAction="*")]
        WebApp.SW_Soap.GetVincResponse GetVinc(WebApp.SW_Soap.GetVincRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetVinc", ReplyAction="*")]
        System.Threading.Tasks.Task<WebApp.SW_Soap.GetVincResponse> GetVincAsync(WebApp.SW_Soap.GetVincRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento FechaIngreso del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CreateVinc", ReplyAction="*")]
        WebApp.SW_Soap.CreateVincResponse CreateVinc(WebApp.SW_Soap.CreateVincRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CreateVinc", ReplyAction="*")]
        System.Threading.Tasks.Task<WebApp.SW_Soap.CreateVincResponse> CreateVincAsync(WebApp.SW_Soap.CreateVincRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento GetAllVincResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAllVinc", ReplyAction="*")]
        WebApp.SW_Soap.GetAllVincResponse GetAllVinc(WebApp.SW_Soap.GetAllVincRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAllVinc", ReplyAction="*")]
        System.Threading.Tasks.Task<WebApp.SW_Soap.GetAllVincResponse> GetAllVincAsync(WebApp.SW_Soap.GetAllVincRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetConectRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetConect", Namespace="http://tempuri.org/", Order=0)]
        public WebApp.SW_Soap.GetConectRequestBody Body;
        
        public GetConectRequest() {
        }
        
        public GetConectRequest(WebApp.SW_Soap.GetConectRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetConectRequestBody {
        
        public GetConectRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetConectResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetConectResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebApp.SW_Soap.GetConectResponseBody Body;
        
        public GetConectResponse() {
        }
        
        public GetConectResponse(WebApp.SW_Soap.GetConectResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetConectResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetConectResult;
        
        public GetConectResponseBody() {
        }
        
        public GetConectResponseBody(string GetConectResult) {
            this.GetConectResult = GetConectResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CreateEmplRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CreateEmpl", Namespace="http://tempuri.org/", Order=0)]
        public WebApp.SW_Soap.CreateEmplRequestBody Body;
        
        public CreateEmplRequest() {
        }
        
        public CreateEmplRequest(WebApp.SW_Soap.CreateEmplRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CreateEmplRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Nombres;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Apellidos;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Direccion;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string Email;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=4)]
        public int IdGenero;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=5)]
        public int IdCiudad;
        
        public CreateEmplRequestBody() {
        }
        
        public CreateEmplRequestBody(string Nombres, string Apellidos, string Direccion, string Email, int IdGenero, int IdCiudad) {
            this.Nombres = Nombres;
            this.Apellidos = Apellidos;
            this.Direccion = Direccion;
            this.Email = Email;
            this.IdGenero = IdGenero;
            this.IdCiudad = IdCiudad;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CreateEmplResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CreateEmplResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebApp.SW_Soap.CreateEmplResponseBody Body;
        
        public CreateEmplResponse() {
        }
        
        public CreateEmplResponse(WebApp.SW_Soap.CreateEmplResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CreateEmplResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string CreateEmplResult;
        
        public CreateEmplResponseBody() {
        }
        
        public CreateEmplResponseBody(string CreateEmplResult) {
            this.CreateEmplResult = CreateEmplResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllEmplRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAllEmpl", Namespace="http://tempuri.org/", Order=0)]
        public WebApp.SW_Soap.GetAllEmplRequestBody Body;
        
        public GetAllEmplRequest() {
        }
        
        public GetAllEmplRequest(WebApp.SW_Soap.GetAllEmplRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetAllEmplRequestBody {
        
        public GetAllEmplRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllEmplResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAllEmplResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebApp.SW_Soap.GetAllEmplResponseBody Body;
        
        public GetAllEmplResponse() {
        }
        
        public GetAllEmplResponse(WebApp.SW_Soap.GetAllEmplResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetAllEmplResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetAllEmplResult;
        
        public GetAllEmplResponseBody() {
        }
        
        public GetAllEmplResponseBody(string GetAllEmplResult) {
            this.GetAllEmplResult = GetAllEmplResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetEmplRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetEmpl", Namespace="http://tempuri.org/", Order=0)]
        public WebApp.SW_Soap.GetEmplRequestBody Body;
        
        public GetEmplRequest() {
        }
        
        public GetEmplRequest(WebApp.SW_Soap.GetEmplRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetEmplRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int id;
        
        public GetEmplRequestBody() {
        }
        
        public GetEmplRequestBody(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetEmplResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetEmplResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebApp.SW_Soap.GetEmplResponseBody Body;
        
        public GetEmplResponse() {
        }
        
        public GetEmplResponse(WebApp.SW_Soap.GetEmplResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetEmplResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetEmplResult;
        
        public GetEmplResponseBody() {
        }
        
        public GetEmplResponseBody(string GetEmplResult) {
            this.GetEmplResult = GetEmplResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetVincRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetVinc", Namespace="http://tempuri.org/", Order=0)]
        public WebApp.SW_Soap.GetVincRequestBody Body;
        
        public GetVincRequest() {
        }
        
        public GetVincRequest(WebApp.SW_Soap.GetVincRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetVincRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int id;
        
        public GetVincRequestBody() {
        }
        
        public GetVincRequestBody(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetVincResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetVincResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebApp.SW_Soap.GetVincResponseBody Body;
        
        public GetVincResponse() {
        }
        
        public GetVincResponse(WebApp.SW_Soap.GetVincResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetVincResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetVincResult;
        
        public GetVincResponseBody() {
        }
        
        public GetVincResponseBody(string GetVincResult) {
            this.GetVincResult = GetVincResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CreateVincRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CreateVinc", Namespace="http://tempuri.org/", Order=0)]
        public WebApp.SW_Soap.CreateVincRequestBody Body;
        
        public CreateVincRequest() {
        }
        
        public CreateVincRequest(WebApp.SW_Soap.CreateVincRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CreateVincRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int IdEmpleado;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string FechaIngreso;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public int IdCargo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string FechaRetiro;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string FechaRegistro;
        
        public CreateVincRequestBody() {
        }
        
        public CreateVincRequestBody(int IdEmpleado, string FechaIngreso, int IdCargo, string FechaRetiro, string FechaRegistro) {
            this.IdEmpleado = IdEmpleado;
            this.FechaIngreso = FechaIngreso;
            this.IdCargo = IdCargo;
            this.FechaRetiro = FechaRetiro;
            this.FechaRegistro = FechaRegistro;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CreateVincResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CreateVincResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebApp.SW_Soap.CreateVincResponseBody Body;
        
        public CreateVincResponse() {
        }
        
        public CreateVincResponse(WebApp.SW_Soap.CreateVincResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CreateVincResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string CreateVincResult;
        
        public CreateVincResponseBody() {
        }
        
        public CreateVincResponseBody(string CreateVincResult) {
            this.CreateVincResult = CreateVincResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllVincRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAllVinc", Namespace="http://tempuri.org/", Order=0)]
        public WebApp.SW_Soap.GetAllVincRequestBody Body;
        
        public GetAllVincRequest() {
        }
        
        public GetAllVincRequest(WebApp.SW_Soap.GetAllVincRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetAllVincRequestBody {
        
        public GetAllVincRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllVincResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAllVincResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebApp.SW_Soap.GetAllVincResponseBody Body;
        
        public GetAllVincResponse() {
        }
        
        public GetAllVincResponse(WebApp.SW_Soap.GetAllVincResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetAllVincResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetAllVincResult;
        
        public GetAllVincResponseBody() {
        }
        
        public GetAllVincResponseBody(string GetAllVincResult) {
            this.GetAllVincResult = GetAllVincResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SW_PruebaSoapChannel : WebApp.SW_Soap.SW_PruebaSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SW_PruebaSoapClient : System.ServiceModel.ClientBase<WebApp.SW_Soap.SW_PruebaSoap>, WebApp.SW_Soap.SW_PruebaSoap {
        
        public SW_PruebaSoapClient() {
        }
        
        public SW_PruebaSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SW_PruebaSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SW_PruebaSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SW_PruebaSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebApp.SW_Soap.GetConectResponse WebApp.SW_Soap.SW_PruebaSoap.GetConect(WebApp.SW_Soap.GetConectRequest request) {
            return base.Channel.GetConect(request);
        }
        
        public string GetConect() {
            WebApp.SW_Soap.GetConectRequest inValue = new WebApp.SW_Soap.GetConectRequest();
            inValue.Body = new WebApp.SW_Soap.GetConectRequestBody();
            WebApp.SW_Soap.GetConectResponse retVal = ((WebApp.SW_Soap.SW_PruebaSoap)(this)).GetConect(inValue);
            return retVal.Body.GetConectResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebApp.SW_Soap.GetConectResponse> WebApp.SW_Soap.SW_PruebaSoap.GetConectAsync(WebApp.SW_Soap.GetConectRequest request) {
            return base.Channel.GetConectAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebApp.SW_Soap.GetConectResponse> GetConectAsync() {
            WebApp.SW_Soap.GetConectRequest inValue = new WebApp.SW_Soap.GetConectRequest();
            inValue.Body = new WebApp.SW_Soap.GetConectRequestBody();
            return ((WebApp.SW_Soap.SW_PruebaSoap)(this)).GetConectAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebApp.SW_Soap.CreateEmplResponse WebApp.SW_Soap.SW_PruebaSoap.CreateEmpl(WebApp.SW_Soap.CreateEmplRequest request) {
            return base.Channel.CreateEmpl(request);
        }
        
        public string CreateEmpl(string Nombres, string Apellidos, string Direccion, string Email, int IdGenero, int IdCiudad) {
            WebApp.SW_Soap.CreateEmplRequest inValue = new WebApp.SW_Soap.CreateEmplRequest();
            inValue.Body = new WebApp.SW_Soap.CreateEmplRequestBody();
            inValue.Body.Nombres = Nombres;
            inValue.Body.Apellidos = Apellidos;
            inValue.Body.Direccion = Direccion;
            inValue.Body.Email = Email;
            inValue.Body.IdGenero = IdGenero;
            inValue.Body.IdCiudad = IdCiudad;
            WebApp.SW_Soap.CreateEmplResponse retVal = ((WebApp.SW_Soap.SW_PruebaSoap)(this)).CreateEmpl(inValue);
            return retVal.Body.CreateEmplResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebApp.SW_Soap.CreateEmplResponse> WebApp.SW_Soap.SW_PruebaSoap.CreateEmplAsync(WebApp.SW_Soap.CreateEmplRequest request) {
            return base.Channel.CreateEmplAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebApp.SW_Soap.CreateEmplResponse> CreateEmplAsync(string Nombres, string Apellidos, string Direccion, string Email, int IdGenero, int IdCiudad) {
            WebApp.SW_Soap.CreateEmplRequest inValue = new WebApp.SW_Soap.CreateEmplRequest();
            inValue.Body = new WebApp.SW_Soap.CreateEmplRequestBody();
            inValue.Body.Nombres = Nombres;
            inValue.Body.Apellidos = Apellidos;
            inValue.Body.Direccion = Direccion;
            inValue.Body.Email = Email;
            inValue.Body.IdGenero = IdGenero;
            inValue.Body.IdCiudad = IdCiudad;
            return ((WebApp.SW_Soap.SW_PruebaSoap)(this)).CreateEmplAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebApp.SW_Soap.GetAllEmplResponse WebApp.SW_Soap.SW_PruebaSoap.GetAllEmpl(WebApp.SW_Soap.GetAllEmplRequest request) {
            return base.Channel.GetAllEmpl(request);
        }
        
        public string GetAllEmpl() {
            WebApp.SW_Soap.GetAllEmplRequest inValue = new WebApp.SW_Soap.GetAllEmplRequest();
            inValue.Body = new WebApp.SW_Soap.GetAllEmplRequestBody();
            WebApp.SW_Soap.GetAllEmplResponse retVal = ((WebApp.SW_Soap.SW_PruebaSoap)(this)).GetAllEmpl(inValue);
            return retVal.Body.GetAllEmplResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebApp.SW_Soap.GetAllEmplResponse> WebApp.SW_Soap.SW_PruebaSoap.GetAllEmplAsync(WebApp.SW_Soap.GetAllEmplRequest request) {
            return base.Channel.GetAllEmplAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebApp.SW_Soap.GetAllEmplResponse> GetAllEmplAsync() {
            WebApp.SW_Soap.GetAllEmplRequest inValue = new WebApp.SW_Soap.GetAllEmplRequest();
            inValue.Body = new WebApp.SW_Soap.GetAllEmplRequestBody();
            return ((WebApp.SW_Soap.SW_PruebaSoap)(this)).GetAllEmplAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebApp.SW_Soap.GetEmplResponse WebApp.SW_Soap.SW_PruebaSoap.GetEmpl(WebApp.SW_Soap.GetEmplRequest request) {
            return base.Channel.GetEmpl(request);
        }
        
        public string GetEmpl(int id) {
            WebApp.SW_Soap.GetEmplRequest inValue = new WebApp.SW_Soap.GetEmplRequest();
            inValue.Body = new WebApp.SW_Soap.GetEmplRequestBody();
            inValue.Body.id = id;
            WebApp.SW_Soap.GetEmplResponse retVal = ((WebApp.SW_Soap.SW_PruebaSoap)(this)).GetEmpl(inValue);
            return retVal.Body.GetEmplResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebApp.SW_Soap.GetEmplResponse> WebApp.SW_Soap.SW_PruebaSoap.GetEmplAsync(WebApp.SW_Soap.GetEmplRequest request) {
            return base.Channel.GetEmplAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebApp.SW_Soap.GetEmplResponse> GetEmplAsync(int id) {
            WebApp.SW_Soap.GetEmplRequest inValue = new WebApp.SW_Soap.GetEmplRequest();
            inValue.Body = new WebApp.SW_Soap.GetEmplRequestBody();
            inValue.Body.id = id;
            return ((WebApp.SW_Soap.SW_PruebaSoap)(this)).GetEmplAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebApp.SW_Soap.GetVincResponse WebApp.SW_Soap.SW_PruebaSoap.GetVinc(WebApp.SW_Soap.GetVincRequest request) {
            return base.Channel.GetVinc(request);
        }
        
        public string GetVinc(int id) {
            WebApp.SW_Soap.GetVincRequest inValue = new WebApp.SW_Soap.GetVincRequest();
            inValue.Body = new WebApp.SW_Soap.GetVincRequestBody();
            inValue.Body.id = id;
            WebApp.SW_Soap.GetVincResponse retVal = ((WebApp.SW_Soap.SW_PruebaSoap)(this)).GetVinc(inValue);
            return retVal.Body.GetVincResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebApp.SW_Soap.GetVincResponse> WebApp.SW_Soap.SW_PruebaSoap.GetVincAsync(WebApp.SW_Soap.GetVincRequest request) {
            return base.Channel.GetVincAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebApp.SW_Soap.GetVincResponse> GetVincAsync(int id) {
            WebApp.SW_Soap.GetVincRequest inValue = new WebApp.SW_Soap.GetVincRequest();
            inValue.Body = new WebApp.SW_Soap.GetVincRequestBody();
            inValue.Body.id = id;
            return ((WebApp.SW_Soap.SW_PruebaSoap)(this)).GetVincAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebApp.SW_Soap.CreateVincResponse WebApp.SW_Soap.SW_PruebaSoap.CreateVinc(WebApp.SW_Soap.CreateVincRequest request) {
            return base.Channel.CreateVinc(request);
        }
        
        public string CreateVinc(int IdEmpleado, string FechaIngreso, int IdCargo, string FechaRetiro, string FechaRegistro) {
            WebApp.SW_Soap.CreateVincRequest inValue = new WebApp.SW_Soap.CreateVincRequest();
            inValue.Body = new WebApp.SW_Soap.CreateVincRequestBody();
            inValue.Body.IdEmpleado = IdEmpleado;
            inValue.Body.FechaIngreso = FechaIngreso;
            inValue.Body.IdCargo = IdCargo;
            inValue.Body.FechaRetiro = FechaRetiro;
            inValue.Body.FechaRegistro = FechaRegistro;
            WebApp.SW_Soap.CreateVincResponse retVal = ((WebApp.SW_Soap.SW_PruebaSoap)(this)).CreateVinc(inValue);
            return retVal.Body.CreateVincResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebApp.SW_Soap.CreateVincResponse> WebApp.SW_Soap.SW_PruebaSoap.CreateVincAsync(WebApp.SW_Soap.CreateVincRequest request) {
            return base.Channel.CreateVincAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebApp.SW_Soap.CreateVincResponse> CreateVincAsync(int IdEmpleado, string FechaIngreso, int IdCargo, string FechaRetiro, string FechaRegistro) {
            WebApp.SW_Soap.CreateVincRequest inValue = new WebApp.SW_Soap.CreateVincRequest();
            inValue.Body = new WebApp.SW_Soap.CreateVincRequestBody();
            inValue.Body.IdEmpleado = IdEmpleado;
            inValue.Body.FechaIngreso = FechaIngreso;
            inValue.Body.IdCargo = IdCargo;
            inValue.Body.FechaRetiro = FechaRetiro;
            inValue.Body.FechaRegistro = FechaRegistro;
            return ((WebApp.SW_Soap.SW_PruebaSoap)(this)).CreateVincAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebApp.SW_Soap.GetAllVincResponse WebApp.SW_Soap.SW_PruebaSoap.GetAllVinc(WebApp.SW_Soap.GetAllVincRequest request) {
            return base.Channel.GetAllVinc(request);
        }
        
        public string GetAllVinc() {
            WebApp.SW_Soap.GetAllVincRequest inValue = new WebApp.SW_Soap.GetAllVincRequest();
            inValue.Body = new WebApp.SW_Soap.GetAllVincRequestBody();
            WebApp.SW_Soap.GetAllVincResponse retVal = ((WebApp.SW_Soap.SW_PruebaSoap)(this)).GetAllVinc(inValue);
            return retVal.Body.GetAllVincResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebApp.SW_Soap.GetAllVincResponse> WebApp.SW_Soap.SW_PruebaSoap.GetAllVincAsync(WebApp.SW_Soap.GetAllVincRequest request) {
            return base.Channel.GetAllVincAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebApp.SW_Soap.GetAllVincResponse> GetAllVincAsync() {
            WebApp.SW_Soap.GetAllVincRequest inValue = new WebApp.SW_Soap.GetAllVincRequest();
            inValue.Body = new WebApp.SW_Soap.GetAllVincRequestBody();
            return ((WebApp.SW_Soap.SW_PruebaSoap)(this)).GetAllVincAsync(inValue);
        }
    }
}
