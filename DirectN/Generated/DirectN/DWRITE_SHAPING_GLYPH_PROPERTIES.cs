#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite/ns-dwrite-dwrite_shaping_glyph_properties
public partial struct DWRITE_SHAPING_GLYPH_PROPERTIES : IEquatable<DWRITE_SHAPING_GLYPH_PROPERTIES>
{
    public static readonly DWRITE_SHAPING_GLYPH_PROPERTIES Null = new();
    
    public ushort _bitfield;
    
    public DWRITE_SHAPING_GLYPH_PROPERTIES(ushort value) => this._bitfield = value;
    public override string ToString() => $"0x{_bitfield:x}";
    
    public override readonly bool Equals(object? obj) => obj is DWRITE_SHAPING_GLYPH_PROPERTIES value && Equals(value);
    public readonly bool Equals(DWRITE_SHAPING_GLYPH_PROPERTIES other) => other._bitfield == _bitfield;
    public override readonly int GetHashCode() => _bitfield.GetHashCode();
    public static bool operator ==(DWRITE_SHAPING_GLYPH_PROPERTIES left, DWRITE_SHAPING_GLYPH_PROPERTIES right) => left.Equals(right);
    public static bool operator !=(DWRITE_SHAPING_GLYPH_PROPERTIES left, DWRITE_SHAPING_GLYPH_PROPERTIES right) => !left.Equals(right);
    public static implicit operator ushort(DWRITE_SHAPING_GLYPH_PROPERTIES value) => value._bitfield;
    public static implicit operator DWRITE_SHAPING_GLYPH_PROPERTIES(ushort value) => new(value);
}
