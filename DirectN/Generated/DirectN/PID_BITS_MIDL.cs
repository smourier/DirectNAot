#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct PID_BITS_MIDL : IEquatable<PID_BITS_MIDL>, IValueGet<ushort>
{
    public static readonly PID_BITS_MIDL Null = new();
    
    public ushort Bits;
    
    public PID_BITS_MIDL(ushort value) => this.Bits = value;
    public override readonly string ToString() => $"0x{Bits:x}";
    
    public override readonly bool Equals(object? obj) => obj is PID_BITS_MIDL value && Equals(value);
    public readonly bool Equals(PID_BITS_MIDL other) => other.Bits == Bits;
    public override readonly int GetHashCode() => Bits.GetHashCode();
    public static bool operator ==(PID_BITS_MIDL left, PID_BITS_MIDL right) => left.Equals(right);
    public static bool operator !=(PID_BITS_MIDL left, PID_BITS_MIDL right) => !left.Equals(right);
    public static implicit operator ushort(PID_BITS_MIDL value) => value.Bits;
    public static implicit operator PID_BITS_MIDL(ushort value) => new(value);
    
    readonly ushort IValueGet<ushort>.GetValue() => Bits;
    readonly object? IValueGet.GetValue() => Bits;
}
