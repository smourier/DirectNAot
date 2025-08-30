#nullable enable
namespace DirectN;

public partial struct VIDEO_MODE : IEquatable<VIDEO_MODE>, IValueGet<uint>
{
    public static readonly VIDEO_MODE Null = new();
    
    public uint RequestedMode;
    
    public VIDEO_MODE(uint value) => this.RequestedMode = value;
    public override string ToString() => $"0x{RequestedMode:x}";
    
    public override readonly bool Equals(object? obj) => obj is VIDEO_MODE value && Equals(value);
    public readonly bool Equals(VIDEO_MODE other) => other.RequestedMode == RequestedMode;
    public override readonly int GetHashCode() => RequestedMode.GetHashCode();
    public static bool operator ==(VIDEO_MODE left, VIDEO_MODE right) => left.Equals(right);
    public static bool operator !=(VIDEO_MODE left, VIDEO_MODE right) => !left.Equals(right);
    public static implicit operator uint(VIDEO_MODE value) => value.RequestedMode;
    public static implicit operator VIDEO_MODE(uint value) => new(value);
    
    readonly uint IValueGet<uint>.GetValue() => RequestedMode;
    readonly object? IValueGet.GetValue() => RequestedMode;
}
