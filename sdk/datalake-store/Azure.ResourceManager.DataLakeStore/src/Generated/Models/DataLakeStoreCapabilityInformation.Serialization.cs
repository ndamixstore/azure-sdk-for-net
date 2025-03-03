// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataLakeStore.Models
{
    public partial class DataLakeStoreCapabilityInformation
    {
        internal static DataLakeStoreCapabilityInformation DeserializeDataLakeStoreCapabilityInformation(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Guid> subscriptionId = default;
            Optional<DataLakeStoreSubscriptionState> state = default;
            Optional<int> maxAccountCount = default;
            Optional<int> accountCount = default;
            Optional<bool> migrationState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("subscriptionId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    subscriptionId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    state = new DataLakeStoreSubscriptionState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("maxAccountCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    maxAccountCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("accountCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    accountCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("migrationState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    migrationState = property.Value.GetBoolean();
                    continue;
                }
            }
            return new DataLakeStoreCapabilityInformation(Optional.ToNullable(subscriptionId), Optional.ToNullable(state), Optional.ToNullable(maxAccountCount), Optional.ToNullable(accountCount), Optional.ToNullable(migrationState));
        }
    }
}
