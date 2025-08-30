#nullable enable
namespace DirectN;

public partial struct HTHEME : IEquatable<HTHEME>, IValueGet<nint>
{
    public static readonly HTHEME Null = new();
    
    public nint Value;
    
    public HTHEME(nint value) => this.Value = value;
    public override string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is HTHEME value && Equals(value);
    public readonly bool Equals(HTHEME other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HTHEME left, HTHEME right) => left.Equals(right);
    public static bool operator !=(HTHEME left, HTHEME right) => !left.Equals(right);
    public static implicit operator nint(HTHEME value) => value.Value;
    public static implicit operator HTHEME(nint value) => new(value);
    
    readonly nint IValueGet<nint>.GetValue() => Value;
    readonly object? IValueGet.GetValue() => Value;
}
