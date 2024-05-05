using System;
using Win32InteropBuilder;
using Win32InteropBuilder.Generators;
using Win32InteropBuilder.Model;

namespace DirectNAot.InteropBuilder.Cli
{
    public class DirectNBuilderContext(BuilderConfiguration configuration, IGenerator language) : BuilderContext(configuration, language)
    {
        public override string GetConstantValue(BuilderType type, Constant constant)
        {
            ArgumentNullException.ThrowIfNull(type);
            ArgumentNullException.ThrowIfNull(constant);
            if (Generator is not CSharpGenerator)
                throw new NotSupportedException();

            if (type.FullName == DEVPROPKEY)
            {
                var (fmtid, pid) = ParsePropertyKey(constant.ValueAsText);
                return $"new(new Guid(\"{fmtid}\"), {pid})";
            }

            return base.GetConstantValue(type, constant);
        }

        public override string GetValueAsString(BuilderType type, object? value, string defaultValueAsString)
        {
            if (type.FullName == PWSTR)
                return $"new({defaultValueAsString})";

            return base.GetValueAsString(type, value, defaultValueAsString);
        }

        // types used to define constants
        public static FullName DEVPROPKEY { get; } = new("Windows.Win32.Devices.Properties.DEVPROPKEY");
        public static FullName PWSTR { get; } = new(FullName.FoundationNamespace + ".PWSTR");

        public static (Guid fmtid, uint pid) ParsePropertyKey(string pk)
        {
            ArgumentNullException.ThrowIfNull(pk);
            var split = pk.Split(new[] { '.', '{', '}', ',' }, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
            if (split.Length != 12)
                throw new ArgumentException(null, nameof(pk));

            var guid = new Guid(
                uint.Parse(split[0]),
                ushort.Parse(split[1]),
                ushort.Parse(split[2]),
                byte.Parse(split[3]),
                byte.Parse(split[4]),
                byte.Parse(split[5]),
                byte.Parse(split[6]),
                byte.Parse(split[7]),
                byte.Parse(split[8]),
                byte.Parse(split[9]),
                byte.Parse(split[10]));
            return (guid, uint.Parse(split[11]));
        }
    }
}
