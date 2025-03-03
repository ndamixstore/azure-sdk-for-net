// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.JobRouter
{
    /// <summary> Represents the capacity a job in this channel will consume from a worker. </summary>
    public partial class ChannelConfiguration
    {
        /// <summary> Initializes a new instance of ChannelConfiguration. </summary>
        /// <param name="capacityCostPerJob"> The amount of capacity that an instance of a job of this channel will consume of the total worker capacity. </param>
        public ChannelConfiguration(int capacityCostPerJob)
        {
            CapacityCostPerJob = capacityCostPerJob;
        }

        /// <summary> Initializes a new instance of ChannelConfiguration. </summary>
        /// <param name="capacityCostPerJob"> The amount of capacity that an instance of a job of this channel will consume of the total worker capacity. </param>
        /// <param name="maxNumberOfJobs"> The maximum number of jobs that can be supported concurrently for this channel. </param>
        internal ChannelConfiguration(int capacityCostPerJob, int? maxNumberOfJobs)
        {
            CapacityCostPerJob = capacityCostPerJob;
            MaxNumberOfJobs = maxNumberOfJobs;
        }

        /// <summary> The amount of capacity that an instance of a job of this channel will consume of the total worker capacity. </summary>
        public int CapacityCostPerJob { get; set; }
        /// <summary> The maximum number of jobs that can be supported concurrently for this channel. </summary>
        public int? MaxNumberOfJobs { get; set; }
    }
}
