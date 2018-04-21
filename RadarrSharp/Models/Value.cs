using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace RadarrSharp.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial struct Value
    {
        /// <summary>
        /// The bool
        /// </summary>
        public bool? Bool;

        /// <summary>
        /// The integer
        /// </summary>
        public long? Integer;

        /// <summary>
        /// The integer array
        /// </summary>
        public IList<object> AnythingArray;

        /// <summary>
        /// The string
        /// </summary>
        public string String;
    }

    public partial struct Value
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Value"/> struct.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <param name="serializer">The serializer.</param>
        /// <exception cref="Exception">Cannot convert Value</exception>
        public Value(JsonReader reader, JsonSerializer serializer)
        {
            Bool = null;
            Integer = null;
            AnythingArray = null;
            String = null;

            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                    Integer = serializer.Deserialize<long>(reader);
                    return;
                case JsonToken.Boolean:
                    Bool = serializer.Deserialize<bool>(reader);
                    return;
                case JsonToken.StartArray:
                    AnythingArray = serializer.Deserialize<IList<object>>(reader);
                    return;
                case JsonToken.String:
                case JsonToken.Date:
                    String = serializer.Deserialize<string>(reader);
                    return;
            }
            throw new Exception("Cannot convert Value");
        }

        /// <summary>
        /// Writes the json.
        /// </summary>
        /// <param name="writer">The writer.</param>
        /// <param name="serializer">The serializer.</param>
        /// <exception cref="Exception">Union must not be null</exception>
        public void WriteJson(JsonWriter writer, JsonSerializer serializer)
        {
            if (Bool != null)
            {
                serializer.Serialize(writer, Bool);
                return;
            }
            if (Integer != null)
            {
                serializer.Serialize(writer, Integer);
                return;
            }
            if (AnythingArray != null)
            {
                serializer.Serialize(writer, AnythingArray);
                return;
            }
            if (String != null)
            {
                serializer.Serialize(writer, String);
                return;
            }
            throw new Exception("Union must not be null");
        }
    }
}
