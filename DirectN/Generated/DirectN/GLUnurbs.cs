#nullable enable
namespace DirectN;

public partial struct GLUnurbs : IEquatable<GLUnurbs>, IValueGet<nint>
{
    public static readonly GLUnurbs Null = new();
    
    public nint Value;
    
    public GLUnurbs(nint value) => this.Value = value;
    public override string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is GLUnurbs value && Equals(value);
    public readonly bool Equals(GLUnurbs other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(GLUnurbs left, GLUnurbs right) => left.Equals(right);
    public static bool operator !=(GLUnurbs left, GLUnurbs right) => !left.Equals(right);
    public static implicit operator nint(GLUnurbs value) => value.Value;
    public static implicit operator GLUnurbs(nint value) => new(value);
    
    readonly nint IValueGet<nint>.GetValue() => Value;
    readonly object? IValueGet.GetValue() => Value;
}
