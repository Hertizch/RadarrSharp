using Newtonsoft.Json;
using RadarrSharp.Enums;
using System;

namespace RadarrSharp.Extensions
{
    static class MappingResultExtensions
    {
        public static MappingResult? ValueForString(string str)
        {
            switch (str)
            {
                case "notParsable": return MappingResult.NotParsable;
                case "success": return MappingResult.Success;
                case "titleNotFound": return MappingResult.TitleNotFound;
                default: return null;
            }
        }

        public static MappingResult ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this MappingResult value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case MappingResult.NotParsable: serializer.Serialize(writer, "notParsable"); break;
                case MappingResult.Success: serializer.Serialize(writer, "success"); break;
                case MappingResult.TitleNotFound: serializer.Serialize(writer, "titleNotFound"); break;
            }
        }
    }
}
