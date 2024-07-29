#nullable enable
namespace DirectN;

public partial struct CAPTURE_STREAMTIME : IEquatable<CAPTURE_STREAMTIME>
{
    public static readonly CAPTURE_STREAMTIME Null = new();
    
    public long StreamTime;
    
    public CAPTURE_STREAMTIME(long value) => this.StreamTime = value;
    public override string ToString() => $"0x{StreamTime:x}";
    
    public override readonly bool Equals(object? obj) => obj is CAPTURE_STREAMTIME value && Equals(value);
    public readonly bool Equals(CAPTURE_STREAMTIME other) => other.StreamTime == StreamTime;
    public override readonly int GetHashCode() => StreamTime.GetHashCode();
    public static bool operator ==(CAPTURE_STREAMTIME left, CAPTURE_STREAMTIME right) => left.Equals(right);
    public static bool operator !=(CAPTURE_STREAMTIME left, CAPTURE_STREAMTIME right) => !left.Equals(right);
    public static implicit operator long(CAPTURE_STREAMTIME value) => value.StreamTime;
    public static implicit operator CAPTURE_STREAMTIME(long value) => new(value);
}
