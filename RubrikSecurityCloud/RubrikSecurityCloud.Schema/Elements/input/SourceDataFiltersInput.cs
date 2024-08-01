// SourceDataFiltersInput.cs
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
    #region SourceDataFiltersInput

    public class SourceDataFiltersInput: IInput
    {
        #region members

        //      C# -> ChatbotTimeRangeFilterInput? ModifiedTimeRange
        // GraphQL -> modifiedTimeRange: ChatbotTimeRangeFilterInput (input)
        [JsonProperty("modifiedTimeRange")]
        public ChatbotTimeRangeFilterInput? ModifiedTimeRange { get; set; }

        //      C# -> List<System.String>? SensitiveDataPolicyIds
        // GraphQL -> sensitiveDataPolicyIds: [UUID!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("sensitiveDataPolicyIds")]
        public List<System.String>? SensitiveDataPolicyIds { get; set; }

        //      C# -> List<System.String>? ExtensionWhitelist
        // GraphQL -> extensionWhitelist: [String!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("extensionWhitelist")]
        public List<System.String>? ExtensionWhitelist { get; set; }


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

    } // class SourceDataFiltersInput
    #endregion

} // namespace RubrikSecurityCloud.Types