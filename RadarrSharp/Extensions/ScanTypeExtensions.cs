using Newtonsoft.Json;
using RadarrSharp.Enums;
using System;

namespace RadarrSharp.Extensions
{
    static class ScanTypeExtensions
    {
        public static ScanType? ValueForString(string str)
        {
            switch (str)
            {
                case "": return ScanType.Empty;
                case "Interlaced": return ScanType.Interlaced;
                case "MBAFF": return ScanType.Mbaff;
                case "Progressive": return ScanType.Progressive;
                default: return null;
            }
        }

        public static ScanType ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this ScanType value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case ScanType.Empty: serializer.Serialize(writer, ""); break;
                case ScanType.Interlaced: serializer.Serialize(writer, "Interlaced"); break;
                case ScanType.Mbaff: serializer.Serialize(writer, "MBAFF"); break;
                case ScanType.Progressive: serializer.Serialize(writer, "Progressive"); break;
            }
        }
    }
}
