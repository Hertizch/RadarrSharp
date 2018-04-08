using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using RadarrSharp.Enums;
using RadarrSharp.Extensions;
using System;
using System.Globalization;

namespace RadarrSharp.Helpers
{
    internal class Converter : JsonConverter
    {
        public override bool CanConvert(Type t) =>
            t == typeof(CoverType) ||
            t == typeof(MinimumAvailability) ||
            t == typeof(ScanType) ||
            t == typeof(PathState) ||
            t == typeof(Status) ||
            
            t == typeof(CoverType?) ||
            t == typeof(MinimumAvailability?) ||
            t == typeof(ScanType?) ||
            t == typeof(PathState?) ||
            t == typeof(Status?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (t == typeof(CoverType))
                return CoverTypeExtensions.ReadJson(reader, serializer);
            if (t == typeof(MinimumAvailability))
                return MinimumAvailabilityExtensions.ReadJson(reader, serializer);
            if (t == typeof(ScanType))
                return ScanTypeExtensions.ReadJson(reader, serializer);
            if (t == typeof(PathState))
                return PathStateExtensions.ReadJson(reader, serializer);
            if (t == typeof(Status))
                return StatusExtensions.ReadJson(reader, serializer);

            if (t == typeof(CoverType?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return CoverTypeExtensions.ReadJson(reader, serializer);
            }
            if (t == typeof(MinimumAvailability?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return MinimumAvailabilityExtensions.ReadJson(reader, serializer);
            }
            if (t == typeof(ScanType?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return ScanTypeExtensions.ReadJson(reader, serializer);
            }
            if (t == typeof(PathState?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return PathStateExtensions.ReadJson(reader, serializer);
            }
            if (t == typeof(Status?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return StatusExtensions.ReadJson(reader, serializer);
            }
            throw new Exception("Unknown type");
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var t = value.GetType();

            if (t == typeof(CoverType))
            {
                ((CoverType)value).WriteJson(writer, serializer);
                return;
            }
            if (t == typeof(MinimumAvailability))
            {
                ((MinimumAvailability)value).WriteJson(writer, serializer);
                return;
            }
            if (t == typeof(ScanType))
            {
                ((ScanType)value).WriteJson(writer, serializer);
                return;
            }
            if (t == typeof(PathState))
            {
                ((PathState)value).WriteJson(writer, serializer);
                return;
            }
            if (t == typeof(Status))
            {
                ((Status)value).WriteJson(writer, serializer);
                return;
            }
            throw new Exception("Unknown type");
        }

        internal static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                new Converter(),
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
