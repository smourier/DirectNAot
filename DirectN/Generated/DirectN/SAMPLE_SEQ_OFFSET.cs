#nullable enable
namespace DirectN;

public partial struct SAMPLE_SEQ_OFFSET : IEquatable<SAMPLE_SEQ_OFFSET>, IValueGet<uint>
{
    public static readonly SAMPLE_SEQ_OFFSET Null = new();
    
    public uint _bitfield;
    
    public SAMPLE_SEQ_OFFSET(uint value) => this._bitfield = value;
    public override readonly string ToString() => $"0x{_bitfield:x}";
    
    public override readonly bool Equals(object? obj) => obj is SAMPLE_SEQ_OFFSET value && Equals(value);
    public readonly bool Equals(SAMPLE_SEQ_OFFSET other) => other._bitfield == _bitfield;
    public override readonly int GetHashCode() => _bitfield.GetHashCode();
    public static bool operator ==(SAMPLE_SEQ_OFFSET left, SAMPLE_SEQ_OFFSET right) => left.Equals(right);
    public static bool operator !=(SAMPLE_SEQ_OFFSET left, SAMPLE_SEQ_OFFSET right) => !left.Equals(right);
    public static implicit operator uint(SAMPLE_SEQ_OFFSET value) => value._bitfield;
    public static implicit operator SAMPLE_SEQ_OFFSET(uint value) => new(value);
    
    readonly uint IValueGet<uint>.GetValue() => _bitfield;
    readonly object? IValueGet.GetValue() => _bitfield;
}
