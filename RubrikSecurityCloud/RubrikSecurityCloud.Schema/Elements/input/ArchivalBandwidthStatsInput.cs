// ArchivalBandwidthStatsInput.cs
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
    #region ArchivalBandwidthStatsInput

    public class ArchivalBandwidthStatsInput: IInput
    {
        #region members

        //      C# -> System.String? DataLocationId
        // GraphQL -> dataLocationId: String (scalar)
        [JsonProperty("dataLocationId")]
        public System.String? DataLocationId { get; set; }

        //      C# -> System.String? Range
        // GraphQL -> range: String (scalar)
        [JsonProperty("range")]
        public System.String? Range { get; set; }

        //      C# -> ArchivalBandwidthStatsRequestType? BandwidthType
        // GraphQL -> bandwidthType: ArchivalBandwidthStatsRequestType (enum)
        [JsonProperty("bandwidthType")]
        public ArchivalBandwidthStatsRequestType? BandwidthType { get; set; }

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }


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

    } // class ArchivalBandwidthStatsInput
    #endregion

} // namespace RubrikSecurityCloud.Types