#nullable enable
namespace DirectN;

public partial struct HWAVE : IEquatable<HWAVE>
{
    public static readonly HWAVE Null = new();
    
    public nint Value;
    
    public HWAVE(nint value) => this.Value = value;
    public override string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is HWAVE value && Equals(value);
    public readonly bool Equals(HWAVE other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HWAVE left, HWAVE right) => left.Equals(right);
    public static bool operator !=(HWAVE left, HWAVE right) => !left.Equals(right);
    public static implicit operator nint(HWAVE value) => value.Value;
    public static implicit operator HWAVE(nint value) => new(value);
}
