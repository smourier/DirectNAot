#nullable enable
namespace DirectN;

public partial struct HRGN : IEquatable<HRGN>, IValueGet<nint>
{
    public static readonly HRGN Null = new();
    
    public nint Value;
    
    public HRGN(nint value) => this.Value = value;
    public override readonly string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is HRGN value && Equals(value);
    public readonly bool Equals(HRGN other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HRGN left, HRGN right) => left.Equals(right);
    public static bool operator !=(HRGN left, HRGN right) => !left.Equals(right);
    public static implicit operator nint(HRGN value) => value.Value;
    public static implicit operator HRGN(nint value) => new(value);
    
    readonly nint IValueGet<nint>.GetValue() => Value;
    readonly object? IValueGet.GetValue() => Value;
}
