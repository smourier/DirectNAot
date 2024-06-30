#nullable enable
namespace DirectN;

public partial struct HVIDEO : IEquatable<HVIDEO>
{
    public static readonly HVIDEO Null = new();
    
    public nint Value;
    
    public override readonly bool Equals(object? obj) => obj is HVIDEO value && Equals(value);
    public readonly bool Equals(HVIDEO other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HVIDEO left, HVIDEO right) => left.Equals(right);
    public static bool operator !=(HVIDEO left, HVIDEO right) => !left.Equals(right);
}
