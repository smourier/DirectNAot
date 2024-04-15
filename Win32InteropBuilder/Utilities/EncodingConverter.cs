using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Win32InteropBuilder.Utilities
{
    public class EncodingConverter : JsonConverter<Encoding>
    {
        public override void Write(Utf8JsonWriter writer, Encoding value, JsonSerializerOptions options) => writer.WriteRawValue(value.WebName);
        public override Encoding? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.String)
                return Encoding.GetEncoding(reader.GetString()!);

            throw new NotImplementedException();
        }
    }
}
