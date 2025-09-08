#nullable enable
namespace DirectN;

public partial struct GLUquadric : IEquatable<GLUquadric>, IValueGet<nint>
{
    public static readonly GLUquadric Null = new();
    
    public nint Value;
    
    public GLUquadric(nint value) => this.Value = value;
    public override readonly string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is GLUquadric value && Equals(value);
    public readonly bool Equals(GLUquadric other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(GLUquadric left, GLUquadric right) => left.Equals(right);
    public static bool operator !=(GLUquadric left, GLUquadric right) => !left.Equals(right);
    public static implicit operator nint(GLUquadric value) => value.Value;
    public static implicit operator GLUquadric(nint value) => new(value);
    
    readonly nint IValueGet<nint>.GetValue() => Value;
    readonly object? IValueGet.GetValue() => Value;
}
