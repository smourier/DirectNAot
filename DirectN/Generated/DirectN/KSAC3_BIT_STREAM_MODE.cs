#nullable enable
namespace DirectN;

public partial struct KSAC3_BIT_STREAM_MODE : IEquatable<KSAC3_BIT_STREAM_MODE>
{
    public static readonly KSAC3_BIT_STREAM_MODE Null = new();
    
    public int BitStreamMode;
    
    public KSAC3_BIT_STREAM_MODE(int value) => this.BitStreamMode = value;
    public override string ToString() => $"0x{BitStreamMode:x}";
    
    public override readonly bool Equals(object? obj) => obj is KSAC3_BIT_STREAM_MODE value && Equals(value);
    public readonly bool Equals(KSAC3_BIT_STREAM_MODE other) => other.BitStreamMode == BitStreamMode;
    public override readonly int GetHashCode() => BitStreamMode.GetHashCode();
    public static bool operator ==(KSAC3_BIT_STREAM_MODE left, KSAC3_BIT_STREAM_MODE right) => left.Equals(right);
    public static bool operator !=(KSAC3_BIT_STREAM_MODE left, KSAC3_BIT_STREAM_MODE right) => !left.Equals(right);
    public static implicit operator int(KSAC3_BIT_STREAM_MODE value) => value.BitStreamMode;
    public static implicit operator KSAC3_BIT_STREAM_MODE(int value) => new(value);
}
