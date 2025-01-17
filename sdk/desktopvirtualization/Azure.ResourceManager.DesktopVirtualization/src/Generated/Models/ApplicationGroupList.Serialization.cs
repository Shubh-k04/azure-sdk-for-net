// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DesktopVirtualization;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    internal partial class ApplicationGroupList
    {
        internal static ApplicationGroupList DeserializeApplicationGroupList(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<VirtualApplicationGroupData>> value = default;
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
                    List<VirtualApplicationGroupData> array = new List<VirtualApplicationGroupData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VirtualApplicationGroupData.DeserializeVirtualApplicationGroupData(item));
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
            return new ApplicationGroupList(Optional.ToList(value), nextLink.Value);
        }
    }
}
