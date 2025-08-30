#nullable enable
namespace DirectN;

public partial struct HDRVR : IEquatable<HDRVR>, IValueGet<nint>
{
    public static readonly HDRVR Null = new();
    
    public nint Value;
    
    public HDRVR(nint value) => this.Value = value;
    public override string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is HDRVR value && Equals(value);
    public readonly bool Equals(HDRVR other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HDRVR left, HDRVR right) => left.Equals(right);
    public static bool operator !=(HDRVR left, HDRVR right) => !left.Equals(right);
    public static implicit operator nint(HDRVR value) => value.Value;
    public static implicit operator HDRVR(nint value) => new(value);
    
    readonly nint IValueGet<nint>.GetValue() => Value;
    readonly object? IValueGet.GetValue() => Value;
}
