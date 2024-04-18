using System;
using Win32InteropBuilder;
using Win32InteropBuilder.Languages;
using Win32InteropBuilder.Model;

namespace DirectNAot.InteropBuilder.Cli
{
    public class Builder : Win32InteropBuilder.Builder
    {
        public const string Namespace = "DirectN";

        public override BuilderContext CreateBuilderContext(BuilderConfiguration configuration, ILanguage language)
        {
            var context = new DirectNBuilderContext(configuration, language);
            context.ImplicitNamespaces.Add(Namespace);
            return context;
        }

        private sealed class DirectNBuilderContext(BuilderConfiguration configuration, ILanguage language) : BuilderContext(configuration, language)
        {
            public override string GetConstantValue(BuilderType type, Constant constant)
            {
                ArgumentNullException.ThrowIfNull(type);
                ArgumentNullException.ThrowIfNull(constant);
                if (Language is not CSharpLanguage)
                    throw new NotSupportedException();

                if (type.FullName == DEVPROPKEY)
                {
                    var (fmtid, pid) = ParsePropertyKey(constant.ValueAsText);
                    return $"new(new Guid(\"{fmtid}\"), {pid})";
                }

                return base.GetConstantValue(type, constant);
            }
        }

        // this type is used a lot and defines lots of constants
        public static FullName DEVPROPKEY { get; } = new("Windows.Win32.Devices.Properties.DEVPROPKEY");

        private static (Guid fmtid, uint pid) ParsePropertyKey(string pk)
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
