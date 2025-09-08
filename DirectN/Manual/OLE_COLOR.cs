namespace DirectN;

public partial struct OLE_COLOR : IEquatable<OLE_COLOR>, IEquatable<COLORREF>, IValueGet<uint>
{
    // https://learn.microsoft.com/en-us/openspecs/office_file_formats/ms-oforms/55b9612d-3a9a-4e62-9f68-27af8e479210
    public const uint TypeMask = 0x80000000;
    public const uint TypeDefault = 0x00;
    public const uint PaletteEntry = 0x01;
    public const uint RgbColor = 0x02;
    public const uint SystemPalette = 0x80;

    public static readonly OLE_COLOR Null = new();

    public uint Value;

    public OLE_COLOR(uint value) => this.Value = value;
    public override readonly string ToString() => $"0x{Value:x}";

    [SupportedOSPlatform("windows5.0")]
    public readonly COLORREF ToCOLORREF()
    {
        var masked = Value & ~TypeMask;
        if ((Value & TypeMask) == SystemPalette)
            return Functions.GetSysColor((SYS_COLOR_INDEX)(masked & 0xFFFF));

        return new(masked);
    }

    public override readonly bool Equals(object? obj) => obj is OLE_COLOR value && Equals(value);
    public readonly bool Equals(OLE_COLOR other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(OLE_COLOR left, OLE_COLOR right) => left.Equals(right);
    public static bool operator !=(OLE_COLOR left, OLE_COLOR right) => !left.Equals(right);
    public static implicit operator uint(OLE_COLOR value) => value.Value;
    public static implicit operator OLE_COLOR(uint value) => new(value);

    [SupportedOSPlatform("windows5.0")]
    public readonly bool Equals(COLORREF other) => ToCOLORREF().Equals(other);

    [SupportedOSPlatform("windows5.0")]
    public static bool operator ==(COLORREF left, OLE_COLOR right) => right.Equals(left);

    [SupportedOSPlatform("windows5.0")]
    public static bool operator !=(COLORREF left, OLE_COLOR right) => !right.Equals(left);

    [SupportedOSPlatform("windows5.0")]
    public static bool operator ==(OLE_COLOR left, COLORREF right) => left.Equals(right);

    [SupportedOSPlatform("windows5.0")]
    public static bool operator !=(OLE_COLOR left, COLORREF right) => !left.Equals(right);

    [SupportedOSPlatform("windows5.0")]
    public static implicit operator COLORREF(OLE_COLOR c) => c.ToCOLORREF();
    public static implicit operator OLE_COLOR(COLORREF vc) => new(vc);

    readonly uint IValueGet<uint>.GetValue() => Value;
    readonly object? IValueGet.GetValue() => Value;
}
