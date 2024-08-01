// AwsVmVolumeSpecInputType.cs
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
    #region AwsVmVolumeSpecInputType

    public class AwsVmVolumeSpecInputType: IInput
    {
        #region members

        //      C# -> System.Int32? Key
        // GraphQL -> key: Int (scalar)
        [JsonProperty("key")]
        public System.Int32? Key { get; set; }

        //      C# -> System.Int32? VolumeTypeId
        // GraphQL -> volumeTypeId: Int (scalar)
        [JsonProperty("volumeTypeId")]
        public System.Int32? VolumeTypeId { get; set; }

        //      C# -> System.Int32? SizeGbs
        // GraphQL -> sizeGbs: Int (scalar)
        [JsonProperty("sizeGbs")]
        public System.Int32? SizeGbs { get; set; }

        //      C# -> System.Int32? Iops
        // GraphQL -> iops: Int (scalar)
        [JsonProperty("iops")]
        public System.Int32? Iops { get; set; }


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

    } // class AwsVmVolumeSpecInputType
    #endregion

} // namespace RubrikSecurityCloud.Types