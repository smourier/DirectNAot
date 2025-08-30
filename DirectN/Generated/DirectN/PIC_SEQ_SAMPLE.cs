#nullable enable
namespace DirectN;

public partial struct PIC_SEQ_SAMPLE : IEquatable<PIC_SEQ_SAMPLE>, IValueGet<uint>
{
    public static readonly PIC_SEQ_SAMPLE Null = new();
    
    public uint _bitfield;
    
    public PIC_SEQ_SAMPLE(uint value) => this._bitfield = value;
    public override string ToString() => $"0x{_bitfield:x}";
    
    public override readonly bool Equals(object? obj) => obj is PIC_SEQ_SAMPLE value && Equals(value);
    public readonly bool Equals(PIC_SEQ_SAMPLE other) => other._bitfield == _bitfield;
    public override readonly int GetHashCode() => _bitfield.GetHashCode();
    public static bool operator ==(PIC_SEQ_SAMPLE left, PIC_SEQ_SAMPLE right) => left.Equals(right);
    public static bool operator !=(PIC_SEQ_SAMPLE left, PIC_SEQ_SAMPLE right) => !left.Equals(right);
    public static implicit operator uint(PIC_SEQ_SAMPLE value) => value._bitfield;
    public static implicit operator PIC_SEQ_SAMPLE(uint value) => new(value);
    
    readonly uint IValueGet<uint>.GetValue() => _bitfield;
    readonly object? IValueGet.GetValue() => _bitfield;
}
