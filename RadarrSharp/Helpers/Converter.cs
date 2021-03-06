﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using RadarrSharp.Enums;
using RadarrSharp.Extensions;
using RadarrSharp.Models;
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
            t == typeof(SourceType) ||
            t == typeof(Level) ||
            t == typeof(Protocol) ||
            t == typeof(MappingResult) ||
            t == typeof(Value) ||

            t == typeof(CoverType?) ||
            t == typeof(MinimumAvailability?) ||
            t == typeof(ScanType?) ||
            t == typeof(PathState?) ||
            t == typeof(Status?) ||
            t == typeof(SourceType?) ||
            t == typeof(Level?) ||
            t == typeof(Protocol?) ||
            t == typeof(MappingResult?) ||
            t == typeof(Value?);

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
            if (t == typeof(SourceType))
                return SourceTypeExtensions.ReadJson(reader, serializer);
            if (t == typeof(Level))
                return LevelExtensions.ReadJson(reader, serializer);
            if (t == typeof(Protocol))
                return ProtocolExtensions.ReadJson(reader, serializer);
            if (t == typeof(MappingResult))
                return MappingResultExtensions.ReadJson(reader, serializer);
            if (t == typeof(Value) || t == typeof(Value?))
                return new Value(reader, serializer);

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
            if (t == typeof(SourceType?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return SourceTypeExtensions.ReadJson(reader, serializer);
            }
            if (t == typeof(Level?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return LevelExtensions.ReadJson(reader, serializer);
            }
            if (t == typeof(Protocol?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return ProtocolExtensions.ReadJson(reader, serializer);
            }
            if (t == typeof(MappingResult?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return MappingResultExtensions.ReadJson(reader, serializer);
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
            if (t == typeof(SourceType))
            {
                ((SourceType)value).WriteJson(writer, serializer);
                return;
            }
            if (t == typeof(Level))
            {
                ((Level)value).WriteJson(writer, serializer);
                return;
            }
            if (t == typeof(Protocol))
            {
                ((Protocol)value).WriteJson(writer, serializer);
                return;
            }
            if (t == typeof(MappingResult))
            {
                ((MappingResult)value).WriteJson(writer, serializer);
                return;
            }
            if (t == typeof(Value))
            {
                ((Value)value).WriteJson(writer, serializer);
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
