// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Analytics.Synapse.Artifacts;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Linked service reference type. </summary>
    public partial class LinkedServiceReference
    {
        /// <summary> Initializes a new instance of LinkedServiceReference. </summary>
        /// <param name="type"> Linked service reference type. </param>
        /// <param name="referenceName"> Reference LinkedService name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="referenceName"/> is null. </exception>
        public LinkedServiceReference(LinkedServiceReferenceType type, string referenceName)
        {
            Argument.AssertNotNull(referenceName, nameof(referenceName));

            Type = type;
            ReferenceName = referenceName;
            Parameters = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of LinkedServiceReference. </summary>
        /// <param name="type"> Linked service reference type. </param>
        /// <param name="referenceName"> Reference LinkedService name. </param>
        /// <param name="parameters"> Arguments for LinkedService. </param>
        internal LinkedServiceReference(LinkedServiceReferenceType type, string referenceName, IDictionary<string, object> parameters)
        {
            Type = type;
            ReferenceName = referenceName;
            Parameters = parameters;
        }

        /// <summary> Linked service reference type. </summary>
        public LinkedServiceReferenceType Type { get; set; }
        /// <summary> Reference LinkedService name. </summary>
        public string ReferenceName { get; set; }
        /// <summary> Arguments for LinkedService. </summary>
        public IDictionary<string, object> Parameters { get; }
    }
}
