﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using Microsoft.Azure.Devices.Serialization;
using Newtonsoft.Json;

namespace Microsoft.Azure.Devices.E2ETests.Helpers
{
    public class ThermostatTwin : BasicDigitalTwin
    {
        [JsonProperty("$metadata")]
        public new ThermostatMetadata Metadata { get; set; }

        [JsonProperty("maxTempSinceLastReboot")]
        public double MaxTempSinceLastReboot { get; set; }

        [JsonProperty("targetTemperature")]
        public double TargetTemperature { get; set; }
    }

    public class ThermostatMetadata : DigitalTwinMetadata
    {
        [JsonProperty("maxTempSinceLastReboot")]
        public ReportedPropertyMetadata MaxTempSinceLastReboot { get; set; }

        [JsonProperty("targetTemperature")]
        public WritableProperty TargetTemperature { get; set; }
    }

    public class ReportedPropertyMetadata
    {
        [JsonProperty("lastUpdateTime")]
        public DateTimeOffset LastUpdateTime { get; set; }
    }
}
