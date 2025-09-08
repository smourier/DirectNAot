#nullable enable
namespace DirectN;

public partial struct DXVA_ExtendedFormat : IEquatable<DXVA_ExtendedFormat>, IValueGet<uint>
{
    public static readonly DXVA_ExtendedFormat Null = new();
    
    public uint _bitfield;
    
    public DXVA_ExtendedFormat(uint value) => this._bitfield = value;
    public override readonly string ToString() => $"0x{_bitfield:x}";
    
    public override readonly bool Equals(object? obj) => obj is DXVA_ExtendedFormat value && Equals(value);
    public readonly bool Equals(DXVA_ExtendedFormat other) => other._bitfield == _bitfield;
    public override readonly int GetHashCode() => _bitfield.GetHashCode();
    public static bool operator ==(DXVA_ExtendedFormat left, DXVA_ExtendedFormat right) => left.Equals(right);
    public static bool operator !=(DXVA_ExtendedFormat left, DXVA_ExtendedFormat right) => !left.Equals(right);
    public static implicit operator uint(DXVA_ExtendedFormat value) => value._bitfield;
    public static implicit operator DXVA_ExtendedFormat(uint value) => new(value);
    
    readonly uint IValueGet<uint>.GetValue() => _bitfield;
    readonly object? IValueGet.GetValue() => _bitfield;
}
