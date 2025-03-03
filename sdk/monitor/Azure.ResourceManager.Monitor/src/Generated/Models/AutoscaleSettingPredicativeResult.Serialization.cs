// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class AutoscaleSettingPredicativeResult
    {
        internal static AutoscaleSettingPredicativeResult DeserializeAutoscaleSettingPredicativeResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> timespan = default;
            Optional<TimeSpan> interval = default;
            Optional<string> metricName = default;
            Optional<ResourceIdentifier> targetResourceId = default;
            Optional<IReadOnlyList<PredictiveValue>> data = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timespan"u8))
                {
                    timespan = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("interval"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    interval = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("metricName"u8))
                {
                    metricName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    targetResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("data"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<PredictiveValue> array = new List<PredictiveValue>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PredictiveValue.DeserializePredictiveValue(item));
                    }
                    data = array;
                    continue;
                }
            }
            return new AutoscaleSettingPredicativeResult(timespan.Value, Optional.ToNullable(interval), metricName.Value, targetResourceId.Value, Optional.ToList(data));
        }
    }
}
