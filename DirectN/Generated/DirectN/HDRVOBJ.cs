#nullable enable
namespace DirectN;

public partial struct HDRVOBJ : IEquatable<HDRVOBJ>, IValueGet<nint>
{
    public static readonly HDRVOBJ Null = new();
    
    public nint Value;
    
    public HDRVOBJ(nint value) => this.Value = value;
    public override string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is HDRVOBJ value && Equals(value);
    public readonly bool Equals(HDRVOBJ other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HDRVOBJ left, HDRVOBJ right) => left.Equals(right);
    public static bool operator !=(HDRVOBJ left, HDRVOBJ right) => !left.Equals(right);
    public static implicit operator nint(HDRVOBJ value) => value.Value;
    public static implicit operator HDRVOBJ(nint value) => new(value);
    
    readonly nint IValueGet<nint>.GetValue() => Value;
    readonly object? IValueGet.GetValue() => Value;
}
