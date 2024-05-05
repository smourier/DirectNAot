using System.Collections.Concurrent;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;

namespace DirectN;

[TypeConverter(typeof(D3DCOLORVALUEConverter))]
[StructLayout(LayoutKind.Sequential)]
public partial struct D3DCOLORVALUE : IEquatable<D3DCOLORVALUE>
{
    public float r;
    public float g;
    public float b;
    public float a;

    public D3DCOLORVALUE(int argb)
        : this((uint)argb)
    {
    }

    public D3DCOLORVALUE(int argb, byte alpha)
        : this((uint)((alpha << 24) | argb))
    {
    }

    public D3DCOLORVALUE(uint argb, byte alpha)
        : this(((uint)(alpha << 24) | argb))
    {
    }

    public D3DCOLORVALUE(uint argb)
    {
        a = ByteToSingle((byte)((argb & 0xff000000) >> 24));
        r = ByteToSingle((byte)((argb & 0xff0000) >> 16));
        g = ByteToSingle((byte)((argb & 0xff00) >> 8));
        b = ByteToSingle((byte)(argb & 0xff));
    }

    public D3DCOLORVALUE(float r, float g, float b)
        : this(1f, r, g, b)
    {
    }

    public D3DCOLORVALUE(float a, float r, float g, float b)
    {
#if DEBUG
        if (a < 0 || a > 1)
            throw new ArgumentException(null, nameof(a));

        if (r < 0 || r > 1)
            throw new ArgumentException(null, nameof(r));

        if (g < 0 || g > 1)
            throw new ArgumentException(null, nameof(g));

        if (b < 0 || b > 1)
            throw new ArgumentException(null, nameof(b));
#endif
        this.a = a;
        this.r = r;
        this.g = g;
        this.b = b;
    }

    private static readonly ConcurrentDictionary<uint, string> _names = new();
    private static readonly ConcurrentDictionary<string, D3DCOLORVALUE> _colors = new(StringComparer.OrdinalIgnoreCase);

    static D3DCOLORVALUE()
    {
        foreach (var fi in typeof(D3DCOLORVALUE).GetFields(BindingFlags.Public | BindingFlags.Static))
        {
            var color = (D3DCOLORVALUE)fi.GetValue(null)!;
            _names[color.UInt32Value] = fi.Name;
            _colors[fi.Name] = color;
        }
    }

    private static bool IsHexa(char c) => (c >= '0' && c <= '9') || (c >= 'a' && c <= 'f') || (c >= 'A' && c <= 'F');

    public static D3DCOLORVALUE FromCOLORREF(int color, byte alpha = 255)
    {
        // swap r & b
        var r = (color & 0xFF) << 16;
        var b = (color >> 16) & 0xFF;
        var g = color & 0xFF00;
        return new D3DCOLORVALUE(r | g | b, alpha);
    }

    public static D3DCOLORVALUE FromArgb(byte r, byte g, byte b) => FromArgb(255, r, g, b);
    public static D3DCOLORVALUE FromArgb(byte a, byte r, byte g, byte b) => new(ByteToSingle(a), ByteToSingle(r), ByteToSingle(g), ByteToSingle(b));
    public static D3DCOLORVALUE FromName(string name)
    {
        _ = TryParseFromName(name, out var value);
        return value;
    }

    public static bool TryParseFromName(string name, out D3DCOLORVALUE outValue)
    {
        ArgumentNullException.ThrowIfNull(name);
        outValue = new D3DCOLORVALUE();
        if (name.Length > 0)
        {
            if (name.StartsWith('#'))
            {
                if (uint.TryParse(name.AsSpan(1), System.Globalization.NumberStyles.HexNumber, null, out var ui))
                {
                    outValue = new D3DCOLORVALUE(ui);
                    return true;
                }
            }
            else
            {
                if (_colors.TryGetValue(name, out var value))
                {
                    outValue = value;
                    return true;
                }

                if (IsHexa(name[0]))
                {
                    if (uint.TryParse(name, System.Globalization.NumberStyles.HexNumber, null, out var ui))
                    {
                        outValue = new D3DCOLORVALUE(ui);
                        return true;
                    }
                }
            }
        }
        return false;
    }

    public byte BA { readonly get => SingleToByte(a); set => a = ByteToSingle(value); }
    public byte BR { readonly get => SingleToByte(r); set => r = ByteToSingle(value); }
    public byte BG { readonly get => SingleToByte(g); set => g = ByteToSingle(value); }
    public byte BB { readonly get => SingleToByte(b); set => b = ByteToSingle(value); }
    public readonly uint UInt32Value => (((uint)BA) << 24) | (((uint)BR) << 16) | (((uint)BG) << 8) | BB;
    public readonly int Int32Value => (int)UInt32Value;
    public readonly string HtmlString => "#" + UInt32Value.ToString("X8");

    public readonly string Name
    {
        get
        {
            var value = UInt32Value;
            if (_names.TryGetValue(value, out var name))
                return name;

            return new D3DCOLORVALUE(value).HtmlString;
        }
    }

    public readonly D3DCOLORVALUE Complementary => Hsv.From(this).Complementary.ToD3DCOLORVALUE();
    public readonly Tuple<D3DCOLORVALUE, D3DCOLORVALUE> Triadic
    {
        get
        {
            var value = Hsl.From(this).Triadic;
            return new Tuple<D3DCOLORVALUE, D3DCOLORVALUE>(value.Item1.ToD3DCOLORVALUE(), value.Item2.ToD3DCOLORVALUE());
        }
    }

    public readonly float ScA => RgbToScRgb(BA);
    public readonly float ScR => RgbToScRgb(BR);
    public readonly float ScG => RgbToScRgb(BG);
    public readonly float ScB => RgbToScRgb(BB);

    public static float RgbToScRgb(byte value)
    {
        var val = value / 255.0f;
        if (val <= 0)
            return 0;

        if (val <= 0.04045)
            return val / 12.92f;

        if (val < 1)
            return (float)Math.Pow((val + 0.055) / 1.055, 2.4);

        return 1;
    }

    public static byte ScRgbToRgb(float value)
    {
        if ((value <= 0))
            return 0;

        if (value <= 0.0031308)
            return (byte)((255 * value * 12.92f) + 0.5f);

        if (value < 1)
            return (byte)((255 * ((1.055f * (float)Math.Pow(value, 1.0 / 2.4)) - 0.055f)) + 0.5f);

        return 255;
    }

    public override readonly string ToString()
    {
#if DEBUG
        return Name;
#else
        return HtmlString;
#endif
    }

    public readonly D3DCOLORVALUE ChangeAlpha(byte newAlpha) => FromArgb(newAlpha, BR, BG, BB);
    public readonly D3DCOLORVALUE ChangeAlpha(float newAlpha) => new(newAlpha, r, g, b);
    public readonly float[] ToArray() => [r, g, b, a];
    public override readonly bool Equals(object? obj) => (obj is D3DCOLORVALUE c && Equals(c)) || (obj is D2D_VECTOR_4F v && r == v.x && g == v.y && b == v.z && a == v.w);
    public readonly bool Equals(D3DCOLORVALUE other) => a == other.a && r == other.r && g == other.g && b == other.b;
    public override readonly int GetHashCode() => a.GetHashCode() ^ r.GetHashCode() ^ g.GetHashCode() ^ b.GetHashCode();
    public static bool operator ==(D3DCOLORVALUE left, D3DCOLORVALUE right) => left.Equals(right);
    public static bool operator !=(D3DCOLORVALUE left, D3DCOLORVALUE right) => !left.Equals(right);
    public static bool operator ==(D2D_VECTOR_4F left, D3DCOLORVALUE right) => right.Equals(left);
    public static bool operator !=(D2D_VECTOR_4F left, D3DCOLORVALUE right) => !right.Equals(left);
    public static bool operator ==(D3DCOLORVALUE left, D2D_VECTOR_4F right) => left.Equals(right);
    public static bool operator !=(D3DCOLORVALUE left, D2D_VECTOR_4F right) => !left.Equals(right);
    public static implicit operator D2D_VECTOR_4F(D3DCOLORVALUE c) => new(c.r, c.g, c.b, c.a);
    public static implicit operator D3DCOLORVALUE(D2D_VECTOR_4F vc) => new(vc.x, vc.y, vc.z, vc.w);

    private static float ByteToSingle(byte value) => value / 255f;
    private static byte SingleToByte(float value) => (byte)(value * 255);

    public static readonly D3DCOLORVALUE AliceBlue = new(0xFFF0F8FF);
    public static readonly D3DCOLORVALUE AntiqueWhite = new(0xFFFAEBD7);
    public static readonly D3DCOLORVALUE Aqua = new(0xFF00FFFF);
    public static readonly D3DCOLORVALUE Aquamarine = new(0xFF7FFFD4);
    public static readonly D3DCOLORVALUE Azure = new(0xFFF0FFFF);
    public static readonly D3DCOLORVALUE Beige = new(0xFFF5F5DC);
    public static readonly D3DCOLORVALUE Bisque = new(0xFFFFE4C4);
    public static readonly D3DCOLORVALUE Black = new(0xFF000000);
    public static readonly D3DCOLORVALUE BlanchedAlmond = new(0xFFFFEBCD);
    public static readonly D3DCOLORVALUE Blue = new(0xFF0000FF);
    public static readonly D3DCOLORVALUE BlueViolet = new(0xFF8A2BE2);
    public static readonly D3DCOLORVALUE Brown = new(0xFFA52A2A);
    public static readonly D3DCOLORVALUE BurlyWood = new(0xFFDEB887);
    public static readonly D3DCOLORVALUE CadetBlue = new(0xFF5F9EA0);
    public static readonly D3DCOLORVALUE Chartreuse = new(0xFF7FFF00);
    public static readonly D3DCOLORVALUE Chocolate = new(0xFFD2691E);
    public static readonly D3DCOLORVALUE Coral = new(0xFFFF7F50);
    public static readonly D3DCOLORVALUE CornflowerBlue = new(0xFF6495ED);
    public static readonly D3DCOLORVALUE Cornsilk = new(0xFFFFF8DC);
    public static readonly D3DCOLORVALUE Crimson = new(0xFFDC143C);
    public static readonly D3DCOLORVALUE Cyan = new(0xFF00FFFF);
    public static readonly D3DCOLORVALUE DarkBlue = new(0xFF00008B);
    public static readonly D3DCOLORVALUE DarkCyan = new(0xFF008B8B);
    public static readonly D3DCOLORVALUE DarkGoldenrod = new(0xFFB8860B);
    public static readonly D3DCOLORVALUE DarkGray = new(0xFFA9A9A9);
    public static readonly D3DCOLORVALUE DarkGreen = new(0xFF006400);
    public static readonly D3DCOLORVALUE DarkKhaki = new(0xFFBDB76B);
    public static readonly D3DCOLORVALUE DarkMagenta = new(0xFF8B008B);
    public static readonly D3DCOLORVALUE DarkOliveGreen = new(0xFF556B2F);
    public static readonly D3DCOLORVALUE DarkOrange = new(0xFFFF8C00);
    public static readonly D3DCOLORVALUE DarkOrchid = new(0xFF9932CC);
    public static readonly D3DCOLORVALUE DarkRed = new(0xFF8B0000);
    public static readonly D3DCOLORVALUE DarkSalmon = new(0xFFE9967A);
    public static readonly D3DCOLORVALUE DarkSeaGreen = new(0xFF8FBC8F);
    public static readonly D3DCOLORVALUE DarkSlateBlue = new(0xFF483D8B);
    public static readonly D3DCOLORVALUE DarkSlateGray = new(0xFF2F4F4F);
    public static readonly D3DCOLORVALUE DarkTurquoise = new(0xFF00CED1);
    public static readonly D3DCOLORVALUE DarkViolet = new(0xFF9400D3);
    public static readonly D3DCOLORVALUE DeepPink = new(0xFFFF1493);
    public static readonly D3DCOLORVALUE DeepSkyBlue = new(0xFF00BFFF);
    public static readonly D3DCOLORVALUE DimGray = new(0xFF696969);
    public static readonly D3DCOLORVALUE DodgerBlue = new(0xFF1E90FF);
    public static readonly D3DCOLORVALUE Firebrick = new(0xFFB22222);
    public static readonly D3DCOLORVALUE FloralWhite = new(0xFFFFFAF0);
    public static readonly D3DCOLORVALUE ForestGreen = new(0xFF228B22);
    public static readonly D3DCOLORVALUE Fuchsia = new(0xFFFF00FF);
    public static readonly D3DCOLORVALUE Gainsboro = new(0xFFDCDCDC);
    public static readonly D3DCOLORVALUE GhostWhite = new(0xFFF8F8FF);
    public static readonly D3DCOLORVALUE Gold = new(0xFFFFD700);
    public static readonly D3DCOLORVALUE Goldenrod = new(0xFFDAA520);
    public static readonly D3DCOLORVALUE Gray = new(0xFF808080);
    public static readonly D3DCOLORVALUE Green = new(0xFF008000);
    public static readonly D3DCOLORVALUE GreenYellow = new(0xFFADFF2F);
    public static readonly D3DCOLORVALUE Honeydew = new(0xFFF0FFF0);
    public static readonly D3DCOLORVALUE HotPink = new(0xFFFF69B4);
    public static readonly D3DCOLORVALUE IndianRed = new(0xFFCD5C5C);
    public static readonly D3DCOLORVALUE Indigo = new(0xFF4B0082);
    public static readonly D3DCOLORVALUE Ivory = new(0xFFFFFFF0);
    public static readonly D3DCOLORVALUE Khaki = new(0xFFF0E68C);
    public static readonly D3DCOLORVALUE Lavender = new(0xFFE6E6FA);
    public static readonly D3DCOLORVALUE LavenderBlush = new(0xFFFFF0F5);
    public static readonly D3DCOLORVALUE LawnGreen = new(0xFF7CFC00);
    public static readonly D3DCOLORVALUE LemonChiffon = new(0xFFFFFACD);
    public static readonly D3DCOLORVALUE LightBlue = new(0xFFADD8E6);
    public static readonly D3DCOLORVALUE LightCoral = new(0xFFF08080);
    public static readonly D3DCOLORVALUE LightCyan = new(0xFFE0FFFF);
    public static readonly D3DCOLORVALUE LightGoldenrodYellow = new(0xFFFAFAD2);
    public static readonly D3DCOLORVALUE LightGray = new(0xFFD3D3D3);
    public static readonly D3DCOLORVALUE LightGreen = new(0xFF90EE90);
    public static readonly D3DCOLORVALUE LightPink = new(0xFFFFB6C1);
    public static readonly D3DCOLORVALUE LightSalmon = new(0xFFFFA07A);
    public static readonly D3DCOLORVALUE LightSeaGreen = new(0xFF20B2AA);
    public static readonly D3DCOLORVALUE LightSkyBlue = new(0xFF87CEFA);
    public static readonly D3DCOLORVALUE LightSlateGray = new(0xFF778899);
    public static readonly D3DCOLORVALUE LightSteelBlue = new(0xFFB0C4DE);
    public static readonly D3DCOLORVALUE LightYellow = new(0xFFFFFFE0);
    public static readonly D3DCOLORVALUE Lime = new(0xFF00FF00);
    public static readonly D3DCOLORVALUE LimeGreen = new(0xFF32CD32);
    public static readonly D3DCOLORVALUE Linen = new(0xFFFAF0E6);
    public static readonly D3DCOLORVALUE Magenta = new(0xFFFF00FF);
    public static readonly D3DCOLORVALUE Maroon = new(0xFF800000);
    public static readonly D3DCOLORVALUE MediumAquamarine = new(0xFF66CDAA);
    public static readonly D3DCOLORVALUE MediumBlue = new(0xFF0000CD);
    public static readonly D3DCOLORVALUE MediumOrchid = new(0xFFBA55D3);
    public static readonly D3DCOLORVALUE MediumPurple = new(0xFF9370DB);
    public static readonly D3DCOLORVALUE MediumSeaGreen = new(0xFF3CB371);
    public static readonly D3DCOLORVALUE MediumSlateBlue = new(0xFF7B68EE);
    public static readonly D3DCOLORVALUE MediumSpringGreen = new(0xFF00FA9A);
    public static readonly D3DCOLORVALUE MediumTurquoise = new(0xFF48D1CC);
    public static readonly D3DCOLORVALUE MediumVioletRed = new(0xFFC71585);
    public static readonly D3DCOLORVALUE MidnightBlue = new(0xFF191970);
    public static readonly D3DCOLORVALUE MintCream = new(0xFFF5FFFA);
    public static readonly D3DCOLORVALUE MistyRose = new(0xFFFFE4E1);
    public static readonly D3DCOLORVALUE Moccasin = new(0xFFFFE4B5);
    public static readonly D3DCOLORVALUE NavajoWhite = new(0xFFFFDEAD);
    public static readonly D3DCOLORVALUE Navy = new(0xFF000080);
    public static readonly D3DCOLORVALUE OldLace = new(0xFFFDF5E6);
    public static readonly D3DCOLORVALUE Olive = new(0xFF808000);
    public static readonly D3DCOLORVALUE OliveDrab = new(0xFF6B8E23);
    public static readonly D3DCOLORVALUE Orange = new(0xFFFFA500);
    public static readonly D3DCOLORVALUE OrangeRed = new(0xFFFF4500);
    public static readonly D3DCOLORVALUE Orchid = new(0xFFDA70D6);
    public static readonly D3DCOLORVALUE PaleGoldenrod = new(0xFFEEE8AA);
    public static readonly D3DCOLORVALUE PaleGreen = new(0xFF98FB98);
    public static readonly D3DCOLORVALUE PaleTurquoise = new(0xFFAFEEEE);
    public static readonly D3DCOLORVALUE PaleVioletRed = new(0xFFDB7093);
    public static readonly D3DCOLORVALUE PapayaWhip = new(0xFFFFEFD5);
    public static readonly D3DCOLORVALUE PeachPuff = new(0xFFFFDAB9);
    public static readonly D3DCOLORVALUE Peru = new(0xFFCD853F);
    public static readonly D3DCOLORVALUE Pink = new(0xFFFFC0CB);
    public static readonly D3DCOLORVALUE Plum = new(0xFFDDA0DD);
    public static readonly D3DCOLORVALUE PowderBlue = new(0xFFB0E0E6);
    public static readonly D3DCOLORVALUE Purple = new(0xFF800080);
    public static readonly D3DCOLORVALUE Red = new(0xFFFF0000);
    public static readonly D3DCOLORVALUE RosyBrown = new(0xFFBC8F8F);
    public static readonly D3DCOLORVALUE RoyalBlue = new(0xFF4169E1);
    public static readonly D3DCOLORVALUE SaddleBrown = new(0xFF8B4513);
    public static readonly D3DCOLORVALUE Salmon = new(0xFFFA8072);
    public static readonly D3DCOLORVALUE SandyBrown = new(0xFFF4A460);
    public static readonly D3DCOLORVALUE SeaGreen = new(0xFF2E8B57);
    public static readonly D3DCOLORVALUE SeaShell = new(0xFFFFF5EE);
    public static readonly D3DCOLORVALUE Sienna = new(0xFFA0522D);
    public static readonly D3DCOLORVALUE Silver = new(0xFFC0C0C0);
    public static readonly D3DCOLORVALUE SkyBlue = new(0xFF87CEEB);
    public static readonly D3DCOLORVALUE SlateBlue = new(0xFF6A5ACD);
    public static readonly D3DCOLORVALUE SlateGray = new(0xFF708090);
    public static readonly D3DCOLORVALUE Snow = new(0xFFFFFAFA);
    public static readonly D3DCOLORVALUE SpringGreen = new(0xFF00FF7F);
    public static readonly D3DCOLORVALUE SteelBlue = new(0xFF4682B4);
    public static readonly D3DCOLORVALUE Tan = new(0xFFD2B48C);
    public static readonly D3DCOLORVALUE Teal = new(0xFF008080);
    public static readonly D3DCOLORVALUE Thistle = new(0xFFD8BFD8);
    public static readonly D3DCOLORVALUE Tomato = new(0xFFFF6347);
    public static readonly D3DCOLORVALUE Transparent = new(0x00FFFFFF);
    public static readonly D3DCOLORVALUE Turquoise = new(0xFF40E0D0);
    public static readonly D3DCOLORVALUE Violet = new(0xFFEE82EE);
    public static readonly D3DCOLORVALUE Wheat = new(0xFFF5DEB3);
    public static readonly D3DCOLORVALUE White = new(0xFFFFFFFF);
    public static readonly D3DCOLORVALUE WhiteSmoke = new(0xFFF5F5F5);
    public static readonly D3DCOLORVALUE Yellow = new(0xFFFFFF00);
    public static readonly D3DCOLORVALUE YellowGreen = new(0xFF9ACD32);
}

public class D3DCOLORVALUEConverter : TypeConverter
{
    public override bool CanConvertFrom(ITypeDescriptorContext? context, Type type) => type == typeof(string);
    public override object? ConvertFrom(ITypeDescriptorContext? context, CultureInfo? culture, object? value)
    {
        if (value is string s)
            return D3DCOLORVALUE.FromName(s);

        return null;
    }

    public override object? ConvertTo(ITypeDescriptorContext? context, CultureInfo? culture, object? value, Type destinationType)
    {
        if (destinationType == typeof(string) && value is D3DCOLORVALUE color)
            return color.Name;

        return base.ConvertTo(context, culture, value, destinationType);
    }
}
