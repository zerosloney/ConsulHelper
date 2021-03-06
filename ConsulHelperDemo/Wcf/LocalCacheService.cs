﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18408
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFCache.Model
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ReturnValue", Namespace="http://schemas.datacontract.org/2004/07/WCFCache.Model")]
    public partial class ReturnValue : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private long CacheTickField;
        
        private long RemoteTickField;
        
        private string ValueField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long CacheTick
        {
            get
            {
                return this.CacheTickField;
            }
            set
            {
                this.CacheTickField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long RemoteTick
        {
            get
            {
                return this.RemoteTickField;
            }
            set
            {
                this.RemoteTickField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Value
        {
            get
            {
                return this.ValueField;
            }
            set
            {
                this.ValueField = value;
            }
        }
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="ILocalCacheService")]
public interface ILocalCacheService
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILocalCacheService/GetValue", ReplyAction="http://tempuri.org/ILocalCacheService/GetValueResponse")]
    WCFCache.Model.ReturnValue GetValue(string key);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILocalCacheService/SetValue", ReplyAction="http://tempuri.org/ILocalCacheService/SetValueResponse")]
    bool SetValue(string key, string value);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILocalCacheService/GetValueInTime", ReplyAction="http://tempuri.org/ILocalCacheService/GetValueInTimeResponse")]
    WCFCache.Model.ReturnValue GetValueInTime(string key, System.TimeSpan expiredSpan);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILocalCacheService/Exist", ReplyAction="http://tempuri.org/ILocalCacheService/ExistResponse")]
    bool Exist(string key);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILocalCacheService/IsLocalValid", ReplyAction="http://tempuri.org/ILocalCacheService/IsLocalValidResponse")]
    bool IsLocalValid(string key, System.TimeSpan expiredSpan);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILocalCacheService/Delete", ReplyAction="http://tempuri.org/ILocalCacheService/DeleteResponse")]
    bool Delete(string key);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILocalCacheService/ClearCache", ReplyAction="http://tempuri.org/ILocalCacheService/ClearCacheResponse")]
    int ClearCache();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILocalCacheService/GetCacheCount", ReplyAction="http://tempuri.org/ILocalCacheService/GetCacheCountResponse")]
    int GetCacheCount();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILocalCacheService/GetLocalKeys", ReplyAction="http://tempuri.org/ILocalCacheService/GetLocalKeysResponse")]
    string[] GetLocalKeys(System.TimeSpan expiredSpan);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface ILocalCacheServiceChannel : ILocalCacheService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class LocalCacheServiceClient : System.ServiceModel.ClientBase<ILocalCacheService>, ILocalCacheService
{
    
    public LocalCacheServiceClient()
    {
    }
    
    public LocalCacheServiceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public LocalCacheServiceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public LocalCacheServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public LocalCacheServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public WCFCache.Model.ReturnValue GetValue(string key)
    {
        return base.Channel.GetValue(key);
    }
    
    public bool SetValue(string key, string value)
    {
        return base.Channel.SetValue(key, value);
    }
    
    public WCFCache.Model.ReturnValue GetValueInTime(string key, System.TimeSpan expiredSpan)
    {
        return base.Channel.GetValueInTime(key, expiredSpan);
    }
    
    public bool Exist(string key)
    {
        return base.Channel.Exist(key);
    }
    
    public bool IsLocalValid(string key, System.TimeSpan expiredSpan)
    {
        return base.Channel.IsLocalValid(key, expiredSpan);
    }
    
    public bool Delete(string key)
    {
        return base.Channel.Delete(key);
    }
    
    public int ClearCache()
    {
        return base.Channel.ClearCache();
    }
    
    public int GetCacheCount()
    {
        return base.Channel.GetCacheCount();
    }
    
    public string[] GetLocalKeys(System.TimeSpan expiredSpan)
    {
        return base.Channel.GetLocalKeys(expiredSpan);
    }
}
