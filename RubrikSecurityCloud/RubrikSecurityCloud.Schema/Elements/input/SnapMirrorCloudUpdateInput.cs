// SnapMirrorCloudUpdateInput.cs
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
    #region SnapMirrorCloudUpdateInput

    public class SnapMirrorCloudUpdateInput: IInput
    {
        #region members

        //      C# -> System.String? SnapMirrorCloudId
        // GraphQL -> snapMirrorCloudId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("snapMirrorCloudId")]
        public System.String? SnapMirrorCloudId { get; set; }

        //      C# -> System.String? SnapMirrorLabel
        // GraphQL -> snapMirrorLabel: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("snapMirrorLabel")]
        public System.String? SnapMirrorLabel { get; set; }


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

    } // class SnapMirrorCloudUpdateInput
    #endregion

} // namespace RubrikSecurityCloud.Types