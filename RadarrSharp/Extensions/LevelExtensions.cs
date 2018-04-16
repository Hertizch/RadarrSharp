using Newtonsoft.Json;
using RadarrSharp.Enums;
using System;

namespace RadarrSharp.Extensions
{
    static class LevelExtensions
    {
        public static Level? ValueForString(string str)
        {
            switch (str)
            {
                case "Error": return Level.Error;
                case "Info": return Level.Info;
                case "Warn": return Level.Warn;
                default: return null;
            }
        }

        public static Level ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this Level value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case Level.Error: serializer.Serialize(writer, "Error"); break;
                case Level.Info: serializer.Serialize(writer, "Info"); break;
                case Level.Warn: serializer.Serialize(writer, "Warn"); break;
            }
        }
    }
}
