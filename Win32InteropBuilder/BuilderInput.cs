using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Win32InteropBuilder.Model;

namespace Win32InteropBuilder
{
    [JsonConverter(typeof(BuilderInputConverter))]
    public class BuilderInput
    {
        public BuilderInput(string input)
        {
            ArgumentNullException.ThrowIfNull(input);
            if (input.StartsWith('!'))
            {
                IsReverse = true;
                input = input[1..];
            }
            Input = input;
        }

        public string Input { get; }
        public bool IsReverse { get; }

        public override string ToString() => Input;

        public virtual bool Matches(BuilderType type)
        {
            ArgumentNullException.ThrowIfNull(type);
            var fn = type.FullName.ToString();

            if (fn.Contains(Input))
                return true;

            return false;
        }

        private sealed class BuilderInputConverter : JsonConverter<BuilderInput>
        {
            public override void Write(Utf8JsonWriter writer, BuilderInput value, JsonSerializerOptions options) => throw new NotSupportedException();
            public override BuilderInput? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                if (reader.TokenType == JsonTokenType.String)
                    return new BuilderInput(reader.GetString()!);

                throw new NotImplementedException();
            }
        }
    }
}
