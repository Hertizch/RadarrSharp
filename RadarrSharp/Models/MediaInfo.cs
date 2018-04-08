using RadarrSharp.Enums;
using System;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace RadarrSharp.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class MediaInfo
    {
        /// <summary>
        /// Gets or sets the video codec.
        /// </summary>
        /// <value>
        /// The video codec.
        /// </value>
        [J("videoCodec")] public string VideoCodec { get; set; }

        /// <summary>
        /// Gets or sets the video bitrate.
        /// </summary>
        /// <value>
        /// The video bitrate.
        /// </value>
        [J("videoBitrate")] public long VideoBitrate { get; set; }

        /// <summary>
        /// Gets or sets the video bit depth.
        /// </summary>
        /// <value>
        /// The video bit depth.
        /// </value>
        [J("videoBitDepth")] public long VideoBitDepth { get; set; }

        /// <summary>
        /// Gets or sets the width.
        /// </summary>
        /// <value>
        /// The width.
        /// </value>
        [J("width")] public long Width { get; set; }

        /// <summary>
        /// Gets or sets the height.
        /// </summary>
        /// <value>
        /// The height.
        /// </value>
        [J("height")] public long Height { get; set; }

        /// <summary>
        /// Gets or sets the audio format.
        /// </summary>
        /// <value>
        /// The audio format.
        /// </value>
        [J("audioFormat")] public string AudioFormat { get; set; }

        /// <summary>
        /// Gets or sets the audio bitrate.
        /// </summary>
        /// <value>
        /// The audio bitrate.
        /// </value>
        [J("audioBitrate")] public long AudioBitrate { get; set; }

        /// <summary>
        /// Gets or sets the run time.
        /// </summary>
        /// <value>
        /// The run time.
        /// </value>
        [J("runTime")] public DateTimeOffset RunTime { get; set; }

        /// <summary>
        /// Gets or sets the audio stream count.
        /// </summary>
        /// <value>
        /// The audio stream count.
        /// </value>
        [J("audioStreamCount")] public long AudioStreamCount { get; set; }

        /// <summary>
        /// Gets or sets the audio channels.
        /// </summary>
        /// <value>
        /// The audio channels.
        /// </value>
        [J("audioChannels")] public long AudioChannels { get; set; }

        /// <summary>
        /// Gets or sets the audio channel positions.
        /// </summary>
        /// <value>
        /// The audio channel positions.
        /// </value>
        [J("audioChannelPositions")] public string AudioChannelPositions { get; set; }

        /// <summary>
        /// Gets or sets the audio channel positions text.
        /// </summary>
        /// <value>
        /// The audio channel positions text.
        /// </value>
        [J("audioChannelPositionsText")] public string AudioChannelPositionsText { get; set; }

        /// <summary>
        /// Gets or sets the audio profile.
        /// </summary>
        /// <value>
        /// The audio profile.
        /// </value>
        [J("audioProfile")] public string AudioProfile { get; set; }

        /// <summary>
        /// Gets or sets the video FPS.
        /// </summary>
        /// <value>
        /// The video FPS.
        /// </value>
        [J("videoFps")] public double VideoFps { get; set; }

        /// <summary>
        /// Gets or sets the audio languages.
        /// </summary>
        /// <value>
        /// The audio languages.
        /// </value>
        [J("audioLanguages")] public string AudioLanguages { get; set; }

        /// <summary>
        /// Gets or sets the subtitles.
        /// </summary>
        /// <value>
        /// The subtitles.
        /// </value>
        [J("subtitles")] public string Subtitles { get; set; }

        /// <summary>
        /// Gets or sets the type of the scan.
        /// </summary>
        /// <value>
        /// The type of the scan.
        /// </value>
        [J("scanType")] public ScanType ScanType { get; set; }

        /// <summary>
        /// Gets or sets the schema revision.
        /// </summary>
        /// <value>
        /// The schema revision.
        /// </value>
        [J("schemaRevision")] public long SchemaRevision { get; set; }
    }
}
