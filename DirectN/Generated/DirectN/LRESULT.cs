#nullable enable
namespace DirectN;

public partial struct LRESULT : IEquatable<LRESULT>, IValueGet<nint>
{
    public static readonly LRESULT Null = new();
    
    public nint Value;
    
    public LRESULT(nint value) => this.Value = value;
    public override readonly string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is LRESULT value && Equals(value);
    public readonly bool Equals(LRESULT other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(LRESULT left, LRESULT right) => left.Equals(right);
    public static bool operator !=(LRESULT left, LRESULT right) => !left.Equals(right);
    public static implicit operator nint(LRESULT value) => value.Value;
    public static implicit operator LRESULT(nint value) => new(value);
    
    readonly nint IValueGet<nint>.GetValue() => Value;
    readonly object? IValueGet.GetValue() => Value;
}
