using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Win32InteropBuilder.Model;
using Win32InteropBuilder.Utilities;

namespace Win32InteropBuilder
{
    [JsonConverter(typeof(Converter))]
    public class BuilderTypeInput(string input) : BuilderInput<BuilderType>(input)
    {
        public override bool Matches(BuilderType type)
        {
            ArgumentNullException.ThrowIfNull(type);
            if (string.IsNullOrEmpty(Input) && IsWildcard)
                return true;

            var fn = type.FullName;
            var fns = fn.ToString();
            if (Input == fns)
                return true;

            if (fn.Namespace.EqualsIgnoreCase(Input))
                return true;

            if (fn.Name.EqualsIgnoreCase(Input))
                return true;

            if (IsWildcard)
            {
                if (fn.Namespace.StartsWith(Input + ".", StringComparison.CurrentCultureIgnoreCase))
                    return true;

                if (fn.Name.StartsWith(Input, StringComparison.CurrentCultureIgnoreCase))
                    return true;
            }
            return false;
        }

        private sealed class Converter : JsonConverter<BuilderTypeInput>
        {
            public override void Write(Utf8JsonWriter writer, BuilderTypeInput value, JsonSerializerOptions options) => throw new NotSupportedException();
            public override BuilderTypeInput? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                if (reader.TokenType == JsonTokenType.String)
                    return new BuilderTypeInput(reader.GetString()!);

                throw new NotImplementedException();
            }
        }
    }
}
