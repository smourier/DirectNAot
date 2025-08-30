#nullable enable
namespace DirectN;

public partial struct AM_AC3_BIT_STREAM_MODE : IEquatable<AM_AC3_BIT_STREAM_MODE>, IValueGet<int>
{
    public static readonly AM_AC3_BIT_STREAM_MODE Null = new();
    
    public int BitStreamMode;
    
    public AM_AC3_BIT_STREAM_MODE(int value) => this.BitStreamMode = value;
    public override string ToString() => $"0x{BitStreamMode:x}";
    
    public override readonly bool Equals(object? obj) => obj is AM_AC3_BIT_STREAM_MODE value && Equals(value);
    public readonly bool Equals(AM_AC3_BIT_STREAM_MODE other) => other.BitStreamMode == BitStreamMode;
    public override readonly int GetHashCode() => BitStreamMode.GetHashCode();
    public static bool operator ==(AM_AC3_BIT_STREAM_MODE left, AM_AC3_BIT_STREAM_MODE right) => left.Equals(right);
    public static bool operator !=(AM_AC3_BIT_STREAM_MODE left, AM_AC3_BIT_STREAM_MODE right) => !left.Equals(right);
    public static implicit operator int(AM_AC3_BIT_STREAM_MODE value) => value.BitStreamMode;
    public static implicit operator AM_AC3_BIT_STREAM_MODE(int value) => new(value);
    
    readonly int IValueGet<int>.GetValue() => BitStreamMode;
    readonly object? IValueGet.GetValue() => BitStreamMode;
}
