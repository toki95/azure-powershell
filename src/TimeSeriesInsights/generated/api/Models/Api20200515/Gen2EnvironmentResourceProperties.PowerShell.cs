namespace Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515
{
    using Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.PowerShell;

    /// <summary>Properties of the Gen2 environment.</summary>
    [System.ComponentModel.TypeConverter(typeof(Gen2EnvironmentResourcePropertiesTypeConverter))]
    public partial class Gen2EnvironmentResourceProperties
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.Gen2EnvironmentResourceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentResourceProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentResourceProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new Gen2EnvironmentResourceProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.Gen2EnvironmentResourceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentResourceProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentResourceProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new Gen2EnvironmentResourceProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="Gen2EnvironmentResourceProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentResourceProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.Gen2EnvironmentResourceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal Gen2EnvironmentResourceProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentResourcePropertiesInternal)this).StorageConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2StorageConfigurationOutput) content.GetValueForProperty("StorageConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentResourcePropertiesInternal)this).StorageConfiguration, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.Gen2StorageConfigurationOutputTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentResourcePropertiesInternal)this).WarmStoreConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IWarmStoreConfigurationProperties) content.GetValueForProperty("WarmStoreConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentResourcePropertiesInternal)this).WarmStoreConfiguration, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.WarmStoreConfigurationPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentResourcePropertiesInternal)this).TimeSeriesIdProperty = (Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.ITimeSeriesIdProperty[]) content.GetValueForProperty("TimeSeriesIdProperty",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentResourcePropertiesInternal)this).TimeSeriesIdProperty, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.ITimeSeriesIdProperty>(__y, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.TimeSeriesIdPropertyTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)this).StatusIngress = (Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IIngressEnvironmentStatus) content.GetValueForProperty("StatusIngress",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)this).StatusIngress, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IngressEnvironmentStatusTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)this).IngressState = (Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.IngressState?) content.GetValueForProperty("IngressState",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)this).IngressState, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.IngressState.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)this).WarmStoragePropertiesUsage = (Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IWarmStoragePropertiesUsage) content.GetValueForProperty("WarmStoragePropertiesUsage",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)this).WarmStoragePropertiesUsage, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.WarmStoragePropertiesUsageTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)this).StatusWarmStorage = (Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IWarmStorageEnvironmentStatus) content.GetValueForProperty("StatusWarmStorage",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)this).StatusWarmStorage, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.WarmStorageEnvironmentStatusTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)this).IngressStateDetail = (Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentStateDetails) content.GetValueForProperty("IngressStateDetail",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)this).IngressStateDetail, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.EnvironmentStateDetailsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)this).PropertyUsageStateDetail = (Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IWarmStoragePropertiesUsageStateDetails) content.GetValueForProperty("PropertyUsageStateDetail",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)this).PropertyUsageStateDetail, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.WarmStoragePropertiesUsageStateDetailsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)this).StateDetailCode = (string) content.GetValueForProperty("StateDetailCode",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)this).StateDetailCode, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)this).StateDetailMessage = (string) content.GetValueForProperty("StateDetailMessage",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)this).StateDetailMessage, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)this).PropertyUsageState = (Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.WarmStoragePropertiesState?) content.GetValueForProperty("PropertyUsageState",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)this).PropertyUsageState, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.WarmStoragePropertiesState.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)this).StateDetailCurrentCount = (int?) content.GetValueForProperty("StateDetailCurrentCount",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)this).StateDetailCurrentCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)this).StateDetailMaxCount = (int?) content.GetValueForProperty("StateDetailMaxCount",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)this).StateDetailMaxCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)this).Status = (Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentStatus) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)this).Status, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.EnvironmentStatusTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)this).DataAccessFqdn = (string) content.GetValueForProperty("DataAccessFqdn",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)this).DataAccessFqdn, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)this).DataAccessId = (string) content.GetValueForProperty("DataAccessId",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)this).DataAccessId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentResourcePropertiesInternal)this).StorageConfigurationAccountName = (string) content.GetValueForProperty("StorageConfigurationAccountName",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentResourcePropertiesInternal)this).StorageConfigurationAccountName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentResourcePropertiesInternal)this).WarmStoreConfigurationDataRetention = (global::System.TimeSpan) content.GetValueForProperty("WarmStoreConfigurationDataRetention",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentResourcePropertiesInternal)this).WarmStoreConfigurationDataRetention, (v) => v is global::System.TimeSpan _v ? _v : global::System.Xml.XmlConvert.ToTimeSpan( v.ToString() ));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.Gen2EnvironmentResourceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal Gen2EnvironmentResourceProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentResourcePropertiesInternal)this).StorageConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2StorageConfigurationOutput) content.GetValueForProperty("StorageConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentResourcePropertiesInternal)this).StorageConfiguration, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.Gen2StorageConfigurationOutputTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentResourcePropertiesInternal)this).WarmStoreConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IWarmStoreConfigurationProperties) content.GetValueForProperty("WarmStoreConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentResourcePropertiesInternal)this).WarmStoreConfiguration, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.WarmStoreConfigurationPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentResourcePropertiesInternal)this).TimeSeriesIdProperty = (Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.ITimeSeriesIdProperty[]) content.GetValueForProperty("TimeSeriesIdProperty",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentResourcePropertiesInternal)this).TimeSeriesIdProperty, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.ITimeSeriesIdProperty>(__y, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.TimeSeriesIdPropertyTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)this).StatusIngress = (Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IIngressEnvironmentStatus) content.GetValueForProperty("StatusIngress",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)this).StatusIngress, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IngressEnvironmentStatusTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)this).IngressState = (Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.IngressState?) content.GetValueForProperty("IngressState",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)this).IngressState, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.IngressState.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)this).WarmStoragePropertiesUsage = (Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IWarmStoragePropertiesUsage) content.GetValueForProperty("WarmStoragePropertiesUsage",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)this).WarmStoragePropertiesUsage, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.WarmStoragePropertiesUsageTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)this).StatusWarmStorage = (Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IWarmStorageEnvironmentStatus) content.GetValueForProperty("StatusWarmStorage",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)this).StatusWarmStorage, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.WarmStorageEnvironmentStatusTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)this).IngressStateDetail = (Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentStateDetails) content.GetValueForProperty("IngressStateDetail",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)this).IngressStateDetail, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.EnvironmentStateDetailsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)this).PropertyUsageStateDetail = (Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IWarmStoragePropertiesUsageStateDetails) content.GetValueForProperty("PropertyUsageStateDetail",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)this).PropertyUsageStateDetail, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.WarmStoragePropertiesUsageStateDetailsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)this).StateDetailCode = (string) content.GetValueForProperty("StateDetailCode",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)this).StateDetailCode, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)this).StateDetailMessage = (string) content.GetValueForProperty("StateDetailMessage",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)this).StateDetailMessage, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)this).PropertyUsageState = (Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.WarmStoragePropertiesState?) content.GetValueForProperty("PropertyUsageState",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)this).PropertyUsageState, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.WarmStoragePropertiesState.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)this).StateDetailCurrentCount = (int?) content.GetValueForProperty("StateDetailCurrentCount",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)this).StateDetailCurrentCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)this).StateDetailMaxCount = (int?) content.GetValueForProperty("StateDetailMaxCount",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)this).StateDetailMaxCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)this).Status = (Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentStatus) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)this).Status, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.EnvironmentStatusTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)this).DataAccessFqdn = (string) content.GetValueForProperty("DataAccessFqdn",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)this).DataAccessFqdn, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)this).DataAccessId = (string) content.GetValueForProperty("DataAccessId",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentResourcePropertiesInternal)this).DataAccessId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentResourcePropertiesInternal)this).StorageConfigurationAccountName = (string) content.GetValueForProperty("StorageConfigurationAccountName",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentResourcePropertiesInternal)this).StorageConfigurationAccountName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentResourcePropertiesInternal)this).WarmStoreConfigurationDataRetention = (global::System.TimeSpan) content.GetValueForProperty("WarmStoreConfigurationDataRetention",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentResourcePropertiesInternal)this).WarmStoreConfigurationDataRetention, (v) => v is global::System.TimeSpan _v ? _v : global::System.Xml.XmlConvert.ToTimeSpan( v.ToString() ));
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Properties of the Gen2 environment.
    [System.ComponentModel.TypeConverter(typeof(Gen2EnvironmentResourcePropertiesTypeConverter))]
    public partial interface IGen2EnvironmentResourceProperties

    {

    }
}