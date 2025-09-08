#nullable enable
namespace DirectN;

public partial struct HGLOBAL : IEquatable<HGLOBAL>, IValueGet<nint>
{
    public static readonly HGLOBAL Null = new();
    
    public nint Value;
    
    public HGLOBAL(nint value) => this.Value = value;
    public override readonly string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is HGLOBAL value && Equals(value);
    public readonly bool Equals(HGLOBAL other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HGLOBAL left, HGLOBAL right) => left.Equals(right);
    public static bool operator !=(HGLOBAL left, HGLOBAL right) => !left.Equals(right);
    public static implicit operator nint(HGLOBAL value) => value.Value;
    public static implicit operator HGLOBAL(nint value) => new(value);
    
    readonly nint IValueGet<nint>.GetValue() => Value;
    readonly object? IValueGet.GetValue() => Value;
}
