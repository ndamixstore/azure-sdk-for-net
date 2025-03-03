// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class StackMajorVersion : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DisplayVersion))
            {
                writer.WritePropertyName("displayVersion"u8);
                writer.WriteStringValue(DisplayVersion);
            }
            if (Optional.IsDefined(RuntimeVersion))
            {
                writer.WritePropertyName("runtimeVersion"u8);
                writer.WriteStringValue(RuntimeVersion);
            }
            if (Optional.IsDefined(IsDefault))
            {
                writer.WritePropertyName("isDefault"u8);
                writer.WriteBooleanValue(IsDefault.Value);
            }
            if (Optional.IsCollectionDefined(MinorVersions))
            {
                writer.WritePropertyName("minorVersions"u8);
                writer.WriteStartArray();
                foreach (var item in MinorVersions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IsApplicationInsights))
            {
                writer.WritePropertyName("applicationInsights"u8);
                writer.WriteBooleanValue(IsApplicationInsights.Value);
            }
            if (Optional.IsDefined(IsPreview))
            {
                writer.WritePropertyName("isPreview"u8);
                writer.WriteBooleanValue(IsPreview.Value);
            }
            if (Optional.IsDefined(IsDeprecated))
            {
                writer.WritePropertyName("isDeprecated"u8);
                writer.WriteBooleanValue(IsDeprecated.Value);
            }
            if (Optional.IsDefined(IsHidden))
            {
                writer.WritePropertyName("isHidden"u8);
                writer.WriteBooleanValue(IsHidden.Value);
            }
            if (Optional.IsCollectionDefined(AppSettingsDictionary))
            {
                writer.WritePropertyName("appSettingsDictionary"u8);
                writer.WriteStartObject();
                foreach (var item in AppSettingsDictionary)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(item.Value.ToString()).RootElement);
#endif
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(SiteConfigPropertiesDictionary))
            {
                writer.WritePropertyName("siteConfigPropertiesDictionary"u8);
                writer.WriteStartObject();
                foreach (var item in SiteConfigPropertiesDictionary)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(item.Value.ToString()).RootElement);
#endif
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
        }

        internal static StackMajorVersion DeserializeStackMajorVersion(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> displayVersion = default;
            Optional<string> runtimeVersion = default;
            Optional<bool> isDefault = default;
            Optional<IList<StackMinorVersion>> minorVersions = default;
            Optional<bool> applicationInsights = default;
            Optional<bool> isPreview = default;
            Optional<bool> isDeprecated = default;
            Optional<bool> isHidden = default;
            Optional<IDictionary<string, BinaryData>> appSettingsDictionary = default;
            Optional<IDictionary<string, BinaryData>> siteConfigPropertiesDictionary = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("displayVersion"u8))
                {
                    displayVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("runtimeVersion"u8))
                {
                    runtimeVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isDefault"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isDefault = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("minorVersions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<StackMinorVersion> array = new List<StackMinorVersion>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(StackMinorVersion.DeserializeStackMinorVersion(item));
                    }
                    minorVersions = array;
                    continue;
                }
                if (property.NameEquals("applicationInsights"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    applicationInsights = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isPreview"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isPreview = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isDeprecated"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isDeprecated = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isHidden"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isHidden = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("appSettingsDictionary"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, BinaryData.FromString(property0.Value.GetRawText()));
                        }
                    }
                    appSettingsDictionary = dictionary;
                    continue;
                }
                if (property.NameEquals("siteConfigPropertiesDictionary"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, BinaryData.FromString(property0.Value.GetRawText()));
                        }
                    }
                    siteConfigPropertiesDictionary = dictionary;
                    continue;
                }
            }
            return new StackMajorVersion(displayVersion.Value, runtimeVersion.Value, Optional.ToNullable(isDefault), Optional.ToList(minorVersions), Optional.ToNullable(applicationInsights), Optional.ToNullable(isPreview), Optional.ToNullable(isDeprecated), Optional.ToNullable(isHidden), Optional.ToDictionary(appSettingsDictionary), Optional.ToDictionary(siteConfigPropertiesDictionary));
        }
    }
}
