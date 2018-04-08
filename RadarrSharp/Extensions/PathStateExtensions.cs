using Newtonsoft.Json;
using RadarrSharp.Enums;
using System;

namespace RadarrSharp.Extensions
{
    static class PathStateExtensions
    {
        public static PathState? ValueForString(string str)
        {
            switch (str)
            {
                case "static": return PathState.Static;
                default: return null;
            }
        }

        public static PathState ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this PathState value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case PathState.Static: serializer.Serialize(writer, "static"); break;
            }
        }
    }
}
