#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct PID_BITS : IEquatable<PID_BITS>
{
    public static readonly PID_BITS Null = new();
    
    public ushort _bitfield;
    
    public PID_BITS(ushort value) => this._bitfield = value;
    public override string ToString() => $"0x{_bitfield:x}";
    
    public override readonly bool Equals(object? obj) => obj is PID_BITS value && Equals(value);
    public readonly bool Equals(PID_BITS other) => other._bitfield == _bitfield;
    public override readonly int GetHashCode() => _bitfield.GetHashCode();
    public static bool operator ==(PID_BITS left, PID_BITS right) => left.Equals(right);
    public static bool operator !=(PID_BITS left, PID_BITS right) => !left.Equals(right);
    public static implicit operator ushort(PID_BITS value) => value._bitfield;
    public static implicit operator PID_BITS(ushort value) => new(value);
}
