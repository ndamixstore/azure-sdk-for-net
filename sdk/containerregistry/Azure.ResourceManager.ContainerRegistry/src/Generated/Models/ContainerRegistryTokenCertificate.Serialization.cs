// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    public partial class ContainerRegistryTokenCertificate : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name.Value.ToString());
            }
            if (Optional.IsDefined(ExpireOn))
            {
                writer.WritePropertyName("expiry"u8);
                writer.WriteStringValue(ExpireOn.Value, "O");
            }
            if (Optional.IsDefined(Thumbprint))
            {
                writer.WritePropertyName("thumbprint"u8);
                writer.WriteStringValue(Thumbprint);
            }
            if (Optional.IsDefined(EncodedPemCertificate))
            {
                writer.WritePropertyName("encodedPemCertificate"u8);
                writer.WriteStringValue(EncodedPemCertificate);
            }
            writer.WriteEndObject();
        }

        internal static ContainerRegistryTokenCertificate DeserializeContainerRegistryTokenCertificate(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ContainerRegistryTokenCertificateName> name = default;
            Optional<DateTimeOffset> expiry = default;
            Optional<string> thumbprint = default;
            Optional<string> encodedPemCertificate = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    name = new ContainerRegistryTokenCertificateName(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("expiry"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    expiry = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("thumbprint"u8))
                {
                    thumbprint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("encodedPemCertificate"u8))
                {
                    encodedPemCertificate = property.Value.GetString();
                    continue;
                }
            }
            return new ContainerRegistryTokenCertificate(Optional.ToNullable(name), Optional.ToNullable(expiry), thumbprint.Value, encodedPemCertificate.Value);
        }
    }
}
