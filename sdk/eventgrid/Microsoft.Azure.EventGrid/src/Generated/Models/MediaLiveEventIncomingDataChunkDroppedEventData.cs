// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.EventGrid.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Ingest fragment dropped event data.
    /// </summary>
    public partial class MediaLiveEventIncomingDataChunkDroppedEventData
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MediaLiveEventIncomingDataChunkDroppedEventData class.
        /// </summary>
        public MediaLiveEventIncomingDataChunkDroppedEventData()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MediaLiveEventIncomingDataChunkDroppedEventData class.
        /// </summary>
        /// <param name="timestamp">Gets the timestamp of the data chunk
        /// dropped.</param>
        /// <param name="trackType">Gets the type of the track (Audio /
        /// Video).</param>
        /// <param name="bitrate">Gets the bitrate of the track.</param>
        /// <param name="timescale">Gets the timescale of the
        /// Timestamp.</param>
        /// <param name="resultCode">Gets the result code for fragment drop
        /// operation.</param>
        /// <param name="trackName">Gets the name of the track for which
        /// fragment is dropped.</param>
        public MediaLiveEventIncomingDataChunkDroppedEventData(string timestamp = default(string), string trackType = default(string), long? bitrate = default(long?), string timescale = default(string), string resultCode = default(string), string trackName = default(string))
        {
            Timestamp = timestamp;
            TrackType = trackType;
            Bitrate = bitrate;
            Timescale = timescale;
            ResultCode = resultCode;
            TrackName = trackName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the timestamp of the data chunk dropped.
        /// </summary>
        [JsonProperty(PropertyName = "timestamp")]
        public string Timestamp { get; private set; }

        /// <summary>
        /// Gets the type of the track (Audio / Video).
        /// </summary>
        [JsonProperty(PropertyName = "trackType")]
        public string TrackType { get; private set; }

        /// <summary>
        /// Gets the bitrate of the track.
        /// </summary>
        [JsonProperty(PropertyName = "bitrate")]
        public long? Bitrate { get; private set; }

        /// <summary>
        /// Gets the timescale of the Timestamp.
        /// </summary>
        [JsonProperty(PropertyName = "timescale")]
        public string Timescale { get; private set; }

        /// <summary>
        /// Gets the result code for fragment drop operation.
        /// </summary>
        [JsonProperty(PropertyName = "resultCode")]
        public string ResultCode { get; private set; }

        /// <summary>
        /// Gets the name of the track for which fragment is dropped.
        /// </summary>
        [JsonProperty(PropertyName = "trackName")]
        public string TrackName { get; private set; }

    }
}