﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------



[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(Namespace="http://eXia_A4_WCF1", ConfigurationName="ICalculation")]
public interface ICalculation
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://eXia_A4_WCF1/ICalculation/m_add", ReplyAction="http://eXia_A4_WCF1/ICalculation/m_addResponse")]
    int m_add(int n, int m);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://eXia_A4_WCF1/ICalculation/m_add", ReplyAction="http://eXia_A4_WCF1/ICalculation/m_addResponse")]
    System.Threading.Tasks.Task<int> m_addAsync(int n, int m);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://eXia_A4_WCF1/ICalculation/m_sous", ReplyAction="http://eXia_A4_WCF1/ICalculation/m_sousResponse")]
    int m_sous(int n, int m);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://eXia_A4_WCF1/ICalculation/m_sous", ReplyAction="http://eXia_A4_WCF1/ICalculation/m_sousResponse")]
    System.Threading.Tasks.Task<int> m_sousAsync(int n, int m);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface ICalculationChannel : ICalculation, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class CalculationClient : System.ServiceModel.ClientBase<ICalculation>, ICalculation
{
    
    public CalculationClient()
    {
    }
    
    public CalculationClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public CalculationClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public CalculationClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public CalculationClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public int m_add(int n, int m)
    {
        return base.Channel.m_add(n, m);
    }
    
    public System.Threading.Tasks.Task<int> m_addAsync(int n, int m)
    {
        return base.Channel.m_addAsync(n, m);
    }
    
    public int m_sous(int n, int m)
    {
        return base.Channel.m_sous(n, m);
    }
    
    public System.Threading.Tasks.Task<int> m_sousAsync(int n, int m)
    {
        return base.Channel.m_sousAsync(n, m);
    }
}
