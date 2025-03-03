// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.PostgreSql.Models
{
    /// <summary> Billing information related properties of a server. </summary>
    public partial class PostgreSqlSku
    {
        /// <summary> Initializes a new instance of PostgreSqlSku. </summary>
        /// <param name="name"> The name of the sku, typically, tier + family + cores, e.g. B_Gen4_1, GP_Gen5_8. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public PostgreSqlSku(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        /// <summary> Initializes a new instance of PostgreSqlSku. </summary>
        /// <param name="name"> The name of the sku, typically, tier + family + cores, e.g. B_Gen4_1, GP_Gen5_8. </param>
        /// <param name="tier"> The tier of the particular SKU, e.g. Basic. </param>
        /// <param name="capacity"> The scale up/out capacity, representing server&apos;s compute units. </param>
        /// <param name="size"> The size code, to be interpreted by resource as appropriate. </param>
        /// <param name="family"> The family of hardware. </param>
        internal PostgreSqlSku(string name, PostgreSqlSkuTier? tier, int? capacity, string size, string family)
        {
            Name = name;
            Tier = tier;
            Capacity = capacity;
            Size = size;
            Family = family;
        }

        /// <summary> The name of the sku, typically, tier + family + cores, e.g. B_Gen4_1, GP_Gen5_8. </summary>
        public string Name { get; set; }
        /// <summary> The tier of the particular SKU, e.g. Basic. </summary>
        public PostgreSqlSkuTier? Tier { get; set; }
        /// <summary> The scale up/out capacity, representing server&apos;s compute units. </summary>
        public int? Capacity { get; set; }
        /// <summary> The size code, to be interpreted by resource as appropriate. </summary>
        public string Size { get; set; }
        /// <summary> The family of hardware. </summary>
        public string Family { get; set; }
    }
}
