using System;
using System.Linq;
using Win32InteropBuilder;
using Win32InteropBuilder.Generators;
using Win32InteropBuilder.Model;

namespace DirectN.InteropBuilder.Cli
{
    public class DirectNBuilderContext(BuilderConfiguration configuration, IGenerator language) : BuilderContext(configuration, language)
    {
        private static readonly FullName[] _unresolvableTypes =
        [
            new("Windows.System.DispatcherQueueController"),
            new("Windows.UI.Composition.ICompositionSurface"),
            new("Windows.UI.Composition.ICompositionSurface"),
            new("Windows.UI.Composition.CompositionGraphicsDevice"),
            new("Windows.UI.Composition.CompositionTexture"),
            new("Windows.UI.Composition.CompositionCapabilities"),
            new("Windows.UI.Composition.Desktop.DesktopWindowTarget"),
            new("Windows.Foundation.IPropertyValue"),
            new("Windows.Graphics.Effects.IGraphicsEffectSource"),
        ];

        public override SignatureTypeProvider CreateSignatureTypeProvider() => new Stp(this);

        private sealed class Stp(DirectNBuilderContext context) : SignatureTypeProvider(context)
        {
            public override BuilderType GetTypeFromFullName(FullName fullName)
            {
                if (_unresolvableTypes.Contains(fullName))
                    return WellKnownTypes.SystemObject;

                return base.GetTypeFromFullName(fullName);
            }
        }

        public override string GetConstantValue(BuilderType type, Constant constant)
        {
            ArgumentNullException.ThrowIfNull(type);
            ArgumentNullException.ThrowIfNull(constant);
            if (Generator is not CSharpGenerator)
                throw new NotSupportedException();

            if (type.Name == DEVPROPKEY.Name)
            {
                var (fmtid, pid) = ParsePropertyKey(constant.ValueAsText);
                return $"new(new Guid(\"{fmtid}\"), {pid})";
            }

            return base.GetConstantValue(type, constant);
        }

        public override bool GeneratesEquatable(BuilderType type)
        {
            ArgumentNullException.ThrowIfNull(type);
            if (type.FullName == FullName.PWSTR)
                return false;

            if (type.FullName == FullName.PSTR)
                return false;

            return base.GeneratesEquatable(type);
        }

        public override Guid? GetTypeGuid(FullName typeFullName)
        {
            var guid = base.GetTypeGuid(typeFullName);
            if (guid.HasValue)
                return guid;

            if (typeFullName == TypeMappings.IRicheditUiaOverrides)
                return new Guid("f2fb5cc0-b5a9-437f-9ba2-47632082269f");

            if (typeFullName == TypeMappings.ITextServices)
                return new Guid("8d33f740-cf58-11ce-a89d-00aa006cadc5");

            if (typeFullName == TypeMappings.ITextServices2)
                return new Guid("8d33f741-cf58-11ce-a89d-00aa006cadc5");

            if (typeFullName == TypeMappings.ITextHost)
                return new Guid("c5bdd8d0-d26e-11ce-a89e-00aa006cadc5");

            if (typeFullName == TypeMappings.ITextHost2)
                return new Guid("13e670f5-1a5a-11cf-abeb-00aa00b65ea1");

            return null;
        }

        public override bool GeneratesToString(BuilderType type)
        {
            ArgumentNullException.ThrowIfNull(type);
            if (type.FullName == HSTRING)
                return false;

            if (type.FullName == FullName.BOOL)
                return false;

            if (type.FullName == FullName.HRESULT)
                return false;

            return base.GeneratesToString(type);
        }

        public override string GetValueAsString(BuilderType type, object? value, string defaultValueAsString)
        {
            if (type.FullName == FullName.PWSTR || type.FullName == FullName.PSTR)
                return $"new({defaultValueAsString})";

            return base.GetValueAsString(type, value, defaultValueAsString);
        }

        // types used to define constants
        public static FullName DEVPROPKEY { get; } = new("Windows.Win32.Devices.Properties.DEVPROPKEY");
        public static FullName HSTRING { get; } = new("Windows.Win32.System.WinRT.HSTRING");

        public static (Guid fmtid, uint pid) ParsePropertyKey(string pk)
        {
            ArgumentNullException.ThrowIfNull(pk);
            var split = pk.Split(['.', '{', '}', ','], StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
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
