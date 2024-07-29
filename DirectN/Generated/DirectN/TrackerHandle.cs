#nullable enable
namespace DirectN;

public partial struct TrackerHandle : IEquatable<TrackerHandle>
{
    public static readonly TrackerHandle Null = new();
    
    public nint Value;
    
    public TrackerHandle(nint value) => this.Value = value;
    public override string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is TrackerHandle value && Equals(value);
    public readonly bool Equals(TrackerHandle other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(TrackerHandle left, TrackerHandle right) => left.Equals(right);
    public static bool operator !=(TrackerHandle left, TrackerHandle right) => !left.Equals(right);
    public static implicit operator nint(TrackerHandle value) => value.Value;
    public static implicit operator TrackerHandle(nint value) => new(value);
}
