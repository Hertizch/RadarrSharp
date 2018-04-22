using Newtonsoft.Json;
using RadarrSharp.Enums;
using System;

namespace RadarrSharp.Extensions
{
    static class StatusExtensions
    {
        public static Status? ValueForString(string str)
        {
            switch (str)
            {
                case "announced": return Status.Announced;
                case "inCinemas": return Status.InCinemas;
                case "released": return Status.Released;
                case "tba": return Status.Tba;
                default: return null;
            }
        }

        public static Status ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this Status value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case Status.Announced: serializer.Serialize(writer, "announced"); break;
                case Status.InCinemas: serializer.Serialize(writer, "inCinemas"); break;
                case Status.Released: serializer.Serialize(writer, "released"); break;
                case Status.Tba: serializer.Serialize(writer, "tba"); break;
            }
        }
    }
}
