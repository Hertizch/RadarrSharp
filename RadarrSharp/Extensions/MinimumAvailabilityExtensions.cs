using Newtonsoft.Json;
using RadarrSharp.Enums;
using System;

namespace RadarrSharp.Extensions
{
    static class MinimumAvailabilityExtensions
    {
        public static MinimumAvailability? ValueForString(string str)
        {
            switch (str)
            {
                case "announced": return MinimumAvailability.Announced;
                case "released": return MinimumAvailability.Released;
                case "tba": return MinimumAvailability.Tba;
                default: return null;
            }
        }

        public static MinimumAvailability ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this MinimumAvailability value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case MinimumAvailability.Announced: serializer.Serialize(writer, "announced"); break;
                case MinimumAvailability.Released: serializer.Serialize(writer, "released"); break;
                case MinimumAvailability.Tba: serializer.Serialize(writer, "tba"); break;
            }
        }
    }
}
