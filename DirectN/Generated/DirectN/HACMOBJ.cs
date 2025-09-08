#nullable enable
namespace DirectN;

public partial struct HACMOBJ : IEquatable<HACMOBJ>, IValueGet<nint>
{
    public static readonly HACMOBJ Null = new();
    
    public nint Value;
    
    public HACMOBJ(nint value) => this.Value = value;
    public override readonly string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is HACMOBJ value && Equals(value);
    public readonly bool Equals(HACMOBJ other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HACMOBJ left, HACMOBJ right) => left.Equals(right);
    public static bool operator !=(HACMOBJ left, HACMOBJ right) => !left.Equals(right);
    public static implicit operator nint(HACMOBJ value) => value.Value;
    public static implicit operator HACMOBJ(nint value) => new(value);
    
    readonly nint IValueGet<nint>.GetValue() => Value;
    readonly object? IValueGet.GetValue() => Value;
}
