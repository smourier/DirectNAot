#nullable enable
namespace DirectN;

public partial struct HACCEL : IEquatable<HACCEL>
{
    public static readonly HACCEL Null = new();
    
    public nint Value;
    
    public HACCEL(nint value) => this.Value = value;
    public override string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is HACCEL value && Equals(value);
    public readonly bool Equals(HACCEL other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HACCEL left, HACCEL right) => left.Equals(right);
    public static bool operator !=(HACCEL left, HACCEL right) => !left.Equals(right);
    public static implicit operator nint(HACCEL value) => value.Value;
    public static implicit operator HACCEL(nint value) => new(value);
}
