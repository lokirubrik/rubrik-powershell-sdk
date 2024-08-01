// CancelBulkRecoveryInput.cs
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
    #region CancelBulkRecoveryInput

    public class CancelBulkRecoveryInput: IInput
    {
        #region members

        //      C# -> System.String? BulkRecoveryInstanceId
        // GraphQL -> bulkRecoveryInstanceId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("bulkRecoveryInstanceId")]
        public System.String? BulkRecoveryInstanceId { get; set; }

        //      C# -> System.String? SubscriptionId
        // GraphQL -> subscriptionId: UUID (scalar)
        [JsonProperty("subscriptionId")]
        public System.String? SubscriptionId { get; set; }

        //      C# -> System.String? GroupId
        // GraphQL -> groupId: UUID (scalar)
        [JsonProperty("groupId")]
        public System.String? GroupId { get; set; }


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

    } // class CancelBulkRecoveryInput
    #endregion

} // namespace RubrikSecurityCloud.Types