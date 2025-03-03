// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.LabServices.Models
{
    public partial class LabServicesUsageName
    {
        internal static LabServicesUsageName DeserializeLabServicesUsageName(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> localizedValue = default;
            Optional<IReadOnlyList<string>> skuInstances = default;
            Optional<string> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("localizedValue"u8))
                {
                    localizedValue = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("skuInstances"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    skuInstances = array;
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    value = property.Value.GetString();
                    continue;
                }
            }
            return new LabServicesUsageName(localizedValue.Value, Optional.ToList(skuInstances), value.Value);
        }
    }
}
