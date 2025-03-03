// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> Gets or sets the skip file share configuration. </summary>
    public partial class SkipFileShareConfiguration : FileShareConfiguration
    {
        /// <summary> Initializes a new instance of SkipFileShareConfiguration. </summary>
        public SkipFileShareConfiguration()
        {
            ConfigurationType = ConfigurationType.Skip;
        }

        /// <summary> Initializes a new instance of SkipFileShareConfiguration. </summary>
        /// <param name="configurationType"> The type of file share config. </param>
        internal SkipFileShareConfiguration(ConfigurationType configurationType) : base(configurationType)
        {
            ConfigurationType = configurationType;
        }
    }
}
