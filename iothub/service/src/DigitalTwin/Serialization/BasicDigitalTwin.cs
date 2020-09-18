﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;
using Newtonsoft.Json;

namespace Microsoft.Azure.Devices.Serialization
{
    /// <summary>
    /// An optional, helper class for deserializing a digital twin.
    /// </summary>
    public class BasicDigitalTwin
    {
        /// <summary>
        /// The unique Id of the digital twin. This is present at the root of every digital twin.
        /// </summary>
        [JsonProperty("$dtId", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// Information about the model a digital twin conforms to. This field is present on every digital twin.
        /// </summary>
        [JsonProperty("$metadata")]
        public DigitalTwinMetadata Metadata { get; set; } = new DigitalTwinMetadata();

        /// <summary>
        /// Additional properties of the digital twin. This field will contain any properties of the digital twin that are not already defined by the other strong types of this class.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> CustomProperties { get; set; } = new Dictionary<string, object>();
    }
}
