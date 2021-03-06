// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class ConnectionStateSnapshot
    {
        internal static ConnectionStateSnapshot DeserializeConnectionStateSnapshot(JsonElement element)
        {
            ConnectionState? connectionState = default;
            DateTimeOffset? startTime = default;
            DateTimeOffset? endTime = default;
            EvaluationState? evaluationState = default;
            int? avgLatencyInMs = default;
            int? minLatencyInMs = default;
            int? maxLatencyInMs = default;
            int? probesSent = default;
            int? probesFailed = default;
            IReadOnlyList<ConnectivityHop> hops = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("connectionState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    connectionState = new ConnectionState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("startTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("evaluationState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    evaluationState = new EvaluationState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("avgLatencyInMs"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    avgLatencyInMs = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("minLatencyInMs"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minLatencyInMs = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxLatencyInMs"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxLatencyInMs = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("probesSent"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    probesSent = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("probesFailed"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    probesFailed = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("hops"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ConnectivityHop> array = new List<ConnectivityHop>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(ConnectivityHop.DeserializeConnectivityHop(item));
                        }
                    }
                    hops = array;
                    continue;
                }
            }
            return new ConnectionStateSnapshot(connectionState, startTime, endTime, evaluationState, avgLatencyInMs, minLatencyInMs, maxLatencyInMs, probesSent, probesFailed, hops);
        }
    }
}
