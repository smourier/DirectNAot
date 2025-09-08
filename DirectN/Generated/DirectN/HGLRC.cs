#nullable enable
namespace DirectN;

public partial struct HGLRC : IEquatable<HGLRC>, IValueGet<nint>
{
    public static readonly HGLRC Null = new();
    
    public nint Value;
    
    public HGLRC(nint value) => this.Value = value;
    public override readonly string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is HGLRC value && Equals(value);
    public readonly bool Equals(HGLRC other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HGLRC left, HGLRC right) => left.Equals(right);
    public static bool operator !=(HGLRC left, HGLRC right) => !left.Equals(right);
    public static implicit operator nint(HGLRC value) => value.Value;
    public static implicit operator HGLRC(nint value) => new(value);
    
    readonly nint IValueGet<nint>.GetValue() => Value;
    readonly object? IValueGet.GetValue() => Value;
}
