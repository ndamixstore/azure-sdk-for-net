// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class SynapseKustoPoolPatch : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
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
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteObjectValue(Sku);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(OptimizedAutoscale))
            {
                writer.WritePropertyName("optimizedAutoscale"u8);
                writer.WriteObjectValue(OptimizedAutoscale);
            }
            if (Optional.IsDefined(EnableStreamingIngest))
            {
                writer.WritePropertyName("enableStreamingIngest"u8);
                writer.WriteBooleanValue(EnableStreamingIngest.Value);
            }
            if (Optional.IsDefined(EnablePurge))
            {
                writer.WritePropertyName("enablePurge"u8);
                writer.WriteBooleanValue(EnablePurge.Value);
            }
            if (Optional.IsDefined(WorkspaceUid))
            {
                writer.WritePropertyName("workspaceUID"u8);
                writer.WriteStringValue(WorkspaceUid.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static SynapseKustoPoolPatch DeserializeSynapseKustoPoolPatch(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> tags = default;
            Optional<SynapseDataSourceSku> sku = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<KustoPoolState> state = default;
            Optional<ResourceProvisioningState> provisioningState = default;
            Optional<Uri> uri = default;
            Optional<Uri> dataIngestionUri = default;
            Optional<string> stateReason = default;
            Optional<SynapseOptimizedAutoscale> optimizedAutoscale = default;
            Optional<bool> enableStreamingIngest = default;
            Optional<bool> enablePurge = default;
            Optional<SynapseLanguageExtensionsList> languageExtensions = default;
            Optional<Guid> workspaceUID = default;
            foreach (var property in element.EnumerateObject())
            {
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
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sku = SynapseDataSourceSku.DeserializeSynapseDataSourceSku(property.Value);
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
                        if (property0.NameEquals("state"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            state = new KustoPoolState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new ResourceProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("uri"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                uri = null;
                                continue;
                            }
                            uri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("dataIngestionUri"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                dataIngestionUri = null;
                                continue;
                            }
                            dataIngestionUri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("stateReason"u8))
                        {
                            stateReason = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("optimizedAutoscale"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            optimizedAutoscale = SynapseOptimizedAutoscale.DeserializeSynapseOptimizedAutoscale(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("enableStreamingIngest"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            enableStreamingIngest = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("enablePurge"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            enablePurge = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("languageExtensions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            languageExtensions = SynapseLanguageExtensionsList.DeserializeSynapseLanguageExtensionsList(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("workspaceUID"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            workspaceUID = property0.Value.GetGuid();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new SynapseKustoPoolPatch(id, name, type, systemData.Value, Optional.ToDictionary(tags), sku.Value, Optional.ToNullable(state), Optional.ToNullable(provisioningState), uri.Value, dataIngestionUri.Value, stateReason.Value, optimizedAutoscale.Value, Optional.ToNullable(enableStreamingIngest), Optional.ToNullable(enablePurge), languageExtensions.Value, Optional.ToNullable(workspaceUID));
        }
    }
}
