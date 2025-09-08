#nullable enable
namespace DirectN;

public partial struct HMIXER : IEquatable<HMIXER>, IValueGet<nint>
{
    public static readonly HMIXER Null = new();
    
    public nint Value;
    
    public HMIXER(nint value) => this.Value = value;
    public override readonly string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is HMIXER value && Equals(value);
    public readonly bool Equals(HMIXER other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HMIXER left, HMIXER right) => left.Equals(right);
    public static bool operator !=(HMIXER left, HMIXER right) => !left.Equals(right);
    public static implicit operator nint(HMIXER value) => value.Value;
    public static implicit operator HMIXER(nint value) => new(value);
    
    readonly nint IValueGet<nint>.GetValue() => Value;
    readonly object? IValueGet.GetValue() => Value;
}
