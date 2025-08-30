#nullable enable
namespace DirectN;

public partial struct HKEY : IEquatable<HKEY>, IValueGet<nint>
{
    public static readonly HKEY Null = new();
    
    public nint Value;
    
    public HKEY(nint value) => this.Value = value;
    public override string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is HKEY value && Equals(value);
    public readonly bool Equals(HKEY other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HKEY left, HKEY right) => left.Equals(right);
    public static bool operator !=(HKEY left, HKEY right) => !left.Equals(right);
    public static implicit operator nint(HKEY value) => value.Value;
    public static implicit operator HKEY(nint value) => new(value);
    
    readonly nint IValueGet<nint>.GetValue() => Value;
    readonly object? IValueGet.GetValue() => Value;
}
