using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;

namespace Win32InteropBuilder.Utilities
{
    [Serializable]
    public partial class EnumBasedException<T> : Exception where T : Enum
    {
        public EnumBasedException()
        {
            Value = default!;
        }

        public EnumBasedException(T value)
            : base(GetMessage(value))
        {
            Value = value;
        }

        public EnumBasedException(T value, string extraMessage)
            : base(GetMessage(value, extraMessage))
        {
            Value = value;
        }

        public EnumBasedException(T value, Exception innerException)
            : base(GetMessage(value), innerException)
        {
            Value = value;
        }

        public EnumBasedException(T value, string extraMessage, Exception innerException)
            : base(GetMessage(value, extraMessage), innerException)
        {
            Value = value;
        }

        public static void ThrowIfNull(T value, [NotNull] object? argument, [CallerArgumentExpression(nameof(argument))] string? paramName = null)
        {
            if (argument is null)
                throw new EnumBasedException<T>(value, $"Parameter: {paramName}.");
        }

        public T Value { get; }

        private static string GetMessage(T value, string? extraMessage = null)
        {
            var text = Decamelize(value.ToString());
            if (extraMessage != null)
            {
                text += " " + extraMessage;
            }
            return text;
        }

        private static string Decamelize(string text)
        {
            if (string.IsNullOrEmpty(text))
                return text;

            var sb = new StringBuilder(text.Length);
            foreach (var c in text)
            {
                if (sb.Length > 0 && char.GetUnicodeCategory(c) == UnicodeCategory.UppercaseLetter)
                {
                    sb.Append(' ');
                    sb.Append(char.ToLower(c));
                }
                else
                {
                    sb.Append(c);
                }
            }
            sb.Append('.');
            return sb.ToString();
        }
    }
}
