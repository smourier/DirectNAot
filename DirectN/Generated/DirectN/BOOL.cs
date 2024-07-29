#nullable enable
namespace DirectN;

public partial struct BOOL : IEquatable<BOOL>
{
    public static readonly BOOL Null = new();
    
    public int Value;
    
    public BOOL(int value) => this.Value = value;
    
    public override readonly bool Equals(object? obj) => obj is BOOL value && Equals(value);
    public readonly bool Equals(BOOL other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(BOOL left, BOOL right) => left.Equals(right);
    public static bool operator !=(BOOL left, BOOL right) => !left.Equals(right);
    public static implicit operator int(BOOL value) => value.Value;
    public static implicit operator BOOL(int value) => new(value);
}
