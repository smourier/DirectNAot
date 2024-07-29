#nullable enable
namespace DirectN;

public partial struct HFASTMUTEX : IEquatable<HFASTMUTEX>
{
    public static readonly HFASTMUTEX Null = new();
    
    public nint Value;
    
    public HFASTMUTEX(nint value) => this.Value = value;
    public override string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is HFASTMUTEX value && Equals(value);
    public readonly bool Equals(HFASTMUTEX other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HFASTMUTEX left, HFASTMUTEX right) => left.Equals(right);
    public static bool operator !=(HFASTMUTEX left, HFASTMUTEX right) => !left.Equals(right);
    public static implicit operator nint(HFASTMUTEX value) => value.Value;
    public static implicit operator HFASTMUTEX(nint value) => new(value);
}
