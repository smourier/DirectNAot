#nullable enable
namespace DirectN;

public partial struct HACMDRIVER : IEquatable<HACMDRIVER>
{
    public static readonly HACMDRIVER Null = new();
    
    public nint Value;
    
    public HACMDRIVER(nint value) => this.Value = value;
    public override string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is HACMDRIVER value && Equals(value);
    public readonly bool Equals(HACMDRIVER other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HACMDRIVER left, HACMDRIVER right) => left.Equals(right);
    public static bool operator !=(HACMDRIVER left, HACMDRIVER right) => !left.Equals(right);
    public static implicit operator nint(HACMDRIVER value) => value.Value;
    public static implicit operator HACMDRIVER(nint value) => new(value);
}
