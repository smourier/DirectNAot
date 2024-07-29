#nullable enable
namespace DirectN;

public partial struct HACMOBJ : IEquatable<HACMOBJ>
{
    public static readonly HACMOBJ Null = new();
    
    public nint Value;
    
    public HACMOBJ(nint value) => this.Value = value;
    public override string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is HACMOBJ value && Equals(value);
    public readonly bool Equals(HACMOBJ other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HACMOBJ left, HACMOBJ right) => left.Equals(right);
    public static bool operator !=(HACMOBJ left, HACMOBJ right) => !left.Equals(right);
    public static implicit operator nint(HACMOBJ value) => value.Value;
    public static implicit operator HACMOBJ(nint value) => new(value);
}
