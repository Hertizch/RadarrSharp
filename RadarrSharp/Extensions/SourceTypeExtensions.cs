using Newtonsoft.Json;
using RadarrSharp.Enums;
using System;

namespace RadarrSharp.Extensions
{
    static class SourceTypeExtensions
    {
        public static SourceType? ValueForString(string str)
        {
            switch (str)
            {
                case "tmdb": return SourceType.Tmdb;
                default: return null;
            }
        }

        public static SourceType ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this SourceType value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case SourceType.Tmdb: serializer.Serialize(writer, "tmdb"); break;
            }
        }
    }
}
