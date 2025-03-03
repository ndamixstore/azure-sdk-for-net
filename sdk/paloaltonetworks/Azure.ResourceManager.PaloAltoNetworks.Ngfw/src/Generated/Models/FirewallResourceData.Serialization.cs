// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw
{
    public partial class FirewallResourceData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                writer.WriteObjectValue(Identity);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(PanETag))
            {
                writer.WritePropertyName("panEtag"u8);
                writer.WriteStringValue(PanETag);
            }
            writer.WritePropertyName("networkProfile"u8);
            writer.WriteObjectValue(NetworkProfile);
            if (Optional.IsDefined(IsPanoramaManaged))
            {
                writer.WritePropertyName("isPanoramaManaged"u8);
                writer.WriteStringValue(IsPanoramaManaged.Value.ToString());
            }
            if (Optional.IsDefined(PanoramaConfig))
            {
                writer.WritePropertyName("panoramaConfig"u8);
                writer.WriteObjectValue(PanoramaConfig);
            }
            if (Optional.IsDefined(AssociatedRulestack))
            {
                writer.WritePropertyName("associatedRulestack"u8);
                writer.WriteObjectValue(AssociatedRulestack);
            }
            writer.WritePropertyName("dnsSettings"u8);
            writer.WriteObjectValue(DnsSettings);
            if (Optional.IsCollectionDefined(FrontEndSettings))
            {
                writer.WritePropertyName("frontEndSettings"u8);
                writer.WriteStartArray();
                foreach (var item in FrontEndSettings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("planData"u8);
            writer.WriteObjectValue(PlanData);
            writer.WritePropertyName("marketplaceDetails"u8);
            writer.WriteObjectValue(MarketplaceDetails);
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static FirewallResourceData DeserializeFirewallResourceData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AzureResourceManagerManagedIdentityProperties> identity = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> panETag = default;
            NetworkProfile networkProfile = default;
            Optional<BooleanEnum> isPanoramaManaged = default;
            Optional<PanoramaConfig> panoramaConfig = default;
            Optional<RulestackDetails> associatedRulestack = default;
            DnsSettings dnsSettings = default;
            Optional<IList<FrontendSetting>> frontEndSettings = default;
            Optional<ProvisioningState> provisioningState = default;
            PlanData planData = default;
            MarketplaceDetails marketplaceDetails = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    identity = AzureResourceManagerManagedIdentityProperties.DeserializeAzureResourceManagerManagedIdentityProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("panEtag"u8))
                        {
                            panETag = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("networkProfile"u8))
                        {
                            networkProfile = NetworkProfile.DeserializeNetworkProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("isPanoramaManaged"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            isPanoramaManaged = new BooleanEnum(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("panoramaConfig"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            panoramaConfig = PanoramaConfig.DeserializePanoramaConfig(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("associatedRulestack"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            associatedRulestack = RulestackDetails.DeserializeRulestackDetails(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("dnsSettings"u8))
                        {
                            dnsSettings = DnsSettings.DeserializeDnsSettings(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("frontEndSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<FrontendSetting> array = new List<FrontendSetting>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(FrontendSetting.DeserializeFrontendSetting(item));
                            }
                            frontEndSettings = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("planData"u8))
                        {
                            planData = PlanData.DeserializePlanData(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("marketplaceDetails"u8))
                        {
                            marketplaceDetails = MarketplaceDetails.DeserializeMarketplaceDetails(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new FirewallResourceData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, identity.Value, panETag.Value, networkProfile, Optional.ToNullable(isPanoramaManaged), panoramaConfig.Value, associatedRulestack.Value, dnsSettings, Optional.ToList(frontEndSettings), Optional.ToNullable(provisioningState), planData, marketplaceDetails);
        }
    }
}
