// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    internal partial class VmImagesInEdgeZoneListResult
    {
        internal static VmImagesInEdgeZoneListResult DeserializeVmImagesInEdgeZoneListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<VirtualMachineImageBase>> value = default;
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
                    List<VirtualMachineImageBase> array = new List<VirtualMachineImageBase>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VirtualMachineImageBase.DeserializeVirtualMachineImageBase(item));
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
            return new VmImagesInEdgeZoneListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
