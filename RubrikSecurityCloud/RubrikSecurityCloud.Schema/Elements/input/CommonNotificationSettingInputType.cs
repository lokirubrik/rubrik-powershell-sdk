// CommonNotificationSettingInputType.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region CommonNotificationSettingInputType

    public class CommonNotificationSettingInputType: IInput
    {
        #region members

        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String (scalar)
        [JsonProperty("hostname")]
        public System.String? Hostname { get; set; }

        //      C# -> System.Int32? Port
        // GraphQL -> port: Int (scalar)
        [JsonProperty("port")]
        public System.Int32? Port { get; set; }

        //      C# -> NetworkProtocolTypeEnum? NetworkType
        // GraphQL -> networkType: NetworkProtocolTypeEnum (enum)
        [JsonProperty("networkType")]
        public NetworkProtocolTypeEnum? NetworkType { get; set; }

        //      C# -> SmtpSecurityTypeEnum? SecurityType
        // GraphQL -> securityType: SMTPSecurityTypeEnum (enum)
        [JsonProperty("securityType")]
        public SmtpSecurityTypeEnum? SecurityType { get; set; }

        //      C# -> System.String? TrustedCerts
        // GraphQL -> trustedCerts: String (scalar)
        [JsonProperty("trustedCerts")]
        public System.String? TrustedCerts { get; set; }


        #endregion

    
        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;

                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion

    } // class CommonNotificationSettingInputType
    #endregion

} // namespace RubrikSecurityCloud.Types