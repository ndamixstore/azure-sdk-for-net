// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Automation.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Automation
{
    public partial class AutomationRunbookData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
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
            if (Optional.IsDefined(RunbookType))
            {
                writer.WritePropertyName("runbookType"u8);
                writer.WriteStringValue(RunbookType.Value.ToString());
            }
            if (Optional.IsDefined(PublishContentLink))
            {
                writer.WritePropertyName("publishContentLink"u8);
                writer.WriteObjectValue(PublishContentLink);
            }
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            if (Optional.IsDefined(IsLogVerboseEnabled))
            {
                writer.WritePropertyName("logVerbose"u8);
                writer.WriteBooleanValue(IsLogVerboseEnabled.Value);
            }
            if (Optional.IsDefined(IsLogProgressEnabled))
            {
                writer.WritePropertyName("logProgress"u8);
                writer.WriteBooleanValue(IsLogProgressEnabled.Value);
            }
            if (Optional.IsDefined(LogActivityTrace))
            {
                writer.WritePropertyName("logActivityTrace"u8);
                writer.WriteNumberValue(LogActivityTrace.Value);
            }
            if (Optional.IsDefined(JobCount))
            {
                writer.WritePropertyName("jobCount"u8);
                writer.WriteNumberValue(JobCount.Value);
            }
            if (Optional.IsCollectionDefined(Parameters))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStartObject();
                foreach (var item in Parameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(OutputTypes))
            {
                writer.WritePropertyName("outputTypes"u8);
                writer.WriteStartArray();
                foreach (var item in OutputTypes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Draft))
            {
                writer.WritePropertyName("draft"u8);
                writer.WriteObjectValue(Draft);
            }
            if (Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(LastModifiedBy))
            {
                writer.WritePropertyName("lastModifiedBy"u8);
                writer.WriteStringValue(LastModifiedBy);
            }
            if (Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("creationTime"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (Optional.IsDefined(LastModifiedOn))
            {
                writer.WritePropertyName("lastModifiedTime"u8);
                writer.WriteStringValue(LastModifiedOn.Value, "O");
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static AutomationRunbookData DeserializeAutomationRunbookData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ETag> etag = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<AutomationRunbookType> runbookType = default;
            Optional<AutomationContentLink> publishContentLink = default;
            Optional<RunbookState> state = default;
            Optional<bool> logVerbose = default;
            Optional<bool> logProgress = default;
            Optional<int> logActivityTrace = default;
            Optional<int> jobCount = default;
            Optional<IDictionary<string, RunbookParameterDefinition>> parameters = default;
            Optional<IList<string>> outputTypes = default;
            Optional<AutomationRunbookDraft> draft = default;
            Optional<RunbookProvisioningState> provisioningState = default;
            Optional<string> lastModifiedBy = default;
            Optional<DateTimeOffset> creationTime = default;
            Optional<DateTimeOffset> lastModifiedTime = default;
            Optional<string> description = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
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
                        if (property0.NameEquals("runbookType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            runbookType = new AutomationRunbookType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("publishContentLink"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            publishContentLink = AutomationContentLink.DeserializeAutomationContentLink(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("state"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            state = new RunbookState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("logVerbose"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            logVerbose = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("logProgress"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            logProgress = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("logActivityTrace"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            logActivityTrace = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("jobCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            jobCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("parameters"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            Dictionary<string, RunbookParameterDefinition> dictionary = new Dictionary<string, RunbookParameterDefinition>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, RunbookParameterDefinition.DeserializeRunbookParameterDefinition(property1.Value));
                            }
                            parameters = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("outputTypes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            outputTypes = array;
                            continue;
                        }
                        if (property0.NameEquals("draft"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            draft = AutomationRunbookDraft.DeserializeAutomationRunbookDraft(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new RunbookProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("lastModifiedBy"u8))
                        {
                            lastModifiedBy = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("creationTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            creationTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastModifiedTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            lastModifiedTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new AutomationRunbookData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, Optional.ToNullable(etag), Optional.ToNullable(runbookType), publishContentLink.Value, Optional.ToNullable(state), Optional.ToNullable(logVerbose), Optional.ToNullable(logProgress), Optional.ToNullable(logActivityTrace), Optional.ToNullable(jobCount), Optional.ToDictionary(parameters), Optional.ToList(outputTypes), draft.Value, Optional.ToNullable(provisioningState), lastModifiedBy.Value, Optional.ToNullable(creationTime), Optional.ToNullable(lastModifiedTime), description.Value);
        }
    }
}
