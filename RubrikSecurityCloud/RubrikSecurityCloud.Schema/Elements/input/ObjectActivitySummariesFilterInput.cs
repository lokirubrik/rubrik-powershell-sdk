// ObjectActivitySummariesFilterInput.cs
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
    #region ObjectActivitySummariesFilterInput

    public class ObjectActivitySummariesFilterInput: IInput
    {
        #region members

        //      C# -> List<System.String>? ObjectIds
        // GraphQL -> objectIds: [String!] (scalar)
        [JsonProperty("objectIds")]
        public List<System.String>? ObjectIds { get; set; }

        //      C# -> System.String? Sid
        // GraphQL -> sid: String (scalar)
        [JsonProperty("sid")]
        public System.String? Sid { get; set; }

        //      C# -> System.String? PolicyId
        // GraphQL -> policyId: String (scalar)
        [JsonProperty("policyId")]
        public System.String? PolicyId { get; set; }

        //      C# -> System.String? SearchStrForObjectName
        // GraphQL -> searchStrForObjectName: String (scalar)
        [JsonProperty("searchStrForObjectName")]
        public System.String? SearchStrForObjectName { get; set; }

        //      C# -> UserActivityType? UserActivityType
        // GraphQL -> userActivityType: UserActivityType (enum)
        [JsonProperty("userActivityType")]
        public UserActivityType? UserActivityType { get; set; }

        //      C# -> RiskLevelType? Risk
        // GraphQL -> risk: RiskLevelType (enum)
        [JsonProperty("risk")]
        public RiskLevelType? Risk { get; set; }


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

    } // class ObjectActivitySummariesFilterInput
    #endregion

} // namespace RubrikSecurityCloud.Types