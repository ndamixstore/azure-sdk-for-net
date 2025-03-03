// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.IotHub;

namespace Azure.ResourceManager.IotHub.Models
{
    internal partial class EventHubConsumerGroupsListResult
    {
        internal static EventHubConsumerGroupsListResult DeserializeEventHubConsumerGroupsListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<EventHubConsumerGroupInfoData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<EventHubConsumerGroupInfoData> array = new List<EventHubConsumerGroupInfoData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EventHubConsumerGroupInfoData.DeserializeEventHubConsumerGroupInfoData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new EventHubConsumerGroupsListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
