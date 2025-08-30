#nullable enable
namespace DirectN;

public partial struct GLUtesselator : IEquatable<GLUtesselator>, IValueGet<nint>
{
    public static readonly GLUtesselator Null = new();
    
    public nint Value;
    
    public GLUtesselator(nint value) => this.Value = value;
    public override string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is GLUtesselator value && Equals(value);
    public readonly bool Equals(GLUtesselator other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(GLUtesselator left, GLUtesselator right) => left.Equals(right);
    public static bool operator !=(GLUtesselator left, GLUtesselator right) => !left.Equals(right);
    public static implicit operator nint(GLUtesselator value) => value.Value;
    public static implicit operator GLUtesselator(nint value) => new(value);
    
    readonly nint IValueGet<nint>.GetValue() => Value;
    readonly object? IValueGet.GetValue() => Value;
}
