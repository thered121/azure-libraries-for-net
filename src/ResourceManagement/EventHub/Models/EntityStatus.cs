// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.EventHub.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.EventHub;
    using Microsoft.Azure.Management.EventHub.Fluent;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for EntityStatus.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EntityStatus
    {
        [EnumMember(Value = "Active")]
        Active,
        [EnumMember(Value = "Disabled")]
        Disabled,
        [EnumMember(Value = "Restoring")]
        Restoring,
        [EnumMember(Value = "SendDisabled")]
        SendDisabled,
        [EnumMember(Value = "ReceiveDisabled")]
        ReceiveDisabled,
        [EnumMember(Value = "Creating")]
        Creating,
        [EnumMember(Value = "Deleting")]
        Deleting,
        [EnumMember(Value = "Renaming")]
        Renaming,
        [EnumMember(Value = "Unknown")]
        Unknown
    }
    internal static class EntityStatusEnumExtension
    {
        internal static string ToSerializedValue(this EntityStatus? value)
        {
            return value == null ? null : ((EntityStatus)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this EntityStatus value)
        {
            switch( value )
            {
                case EntityStatus.Active:
                    return "Active";
                case EntityStatus.Disabled:
                    return "Disabled";
                case EntityStatus.Restoring:
                    return "Restoring";
                case EntityStatus.SendDisabled:
                    return "SendDisabled";
                case EntityStatus.ReceiveDisabled:
                    return "ReceiveDisabled";
                case EntityStatus.Creating:
                    return "Creating";
                case EntityStatus.Deleting:
                    return "Deleting";
                case EntityStatus.Renaming:
                    return "Renaming";
                case EntityStatus.Unknown:
                    return "Unknown";
            }
            return null;
        }

        internal static EntityStatus? ParseEntityStatus(this string value)
        {
            switch( value )
            {
                case "Active":
                    return EntityStatus.Active;
                case "Disabled":
                    return EntityStatus.Disabled;
                case "Restoring":
                    return EntityStatus.Restoring;
                case "SendDisabled":
                    return EntityStatus.SendDisabled;
                case "ReceiveDisabled":
                    return EntityStatus.ReceiveDisabled;
                case "Creating":
                    return EntityStatus.Creating;
                case "Deleting":
                    return EntityStatus.Deleting;
                case "Renaming":
                    return EntityStatus.Renaming;
                case "Unknown":
                    return EntityStatus.Unknown;
            }
            return null;
        }
    }
}