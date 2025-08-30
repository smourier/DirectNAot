#nullable enable
namespace DirectN;

public partial struct HMENU : IEquatable<HMENU>, IValueGet<nint>
{
    public static readonly HMENU Null = new();
    
    public nint Value;
    
    public HMENU(nint value) => this.Value = value;
    public override string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is HMENU value && Equals(value);
    public readonly bool Equals(HMENU other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HMENU left, HMENU right) => left.Equals(right);
    public static bool operator !=(HMENU left, HMENU right) => !left.Equals(right);
    public static implicit operator nint(HMENU value) => value.Value;
    public static implicit operator HMENU(nint value) => new(value);
    
    readonly nint IValueGet<nint>.GetValue() => Value;
    readonly object? IValueGet.GetValue() => Value;
}
