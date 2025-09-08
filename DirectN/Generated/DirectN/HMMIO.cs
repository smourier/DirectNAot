#nullable enable
namespace DirectN;

public partial struct HMMIO : IEquatable<HMMIO>, IValueGet<nint>
{
    public static readonly HMMIO Null = new();
    
    public nint Value;
    
    public HMMIO(nint value) => this.Value = value;
    public override readonly string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is HMMIO value && Equals(value);
    public readonly bool Equals(HMMIO other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HMMIO left, HMMIO right) => left.Equals(right);
    public static bool operator !=(HMMIO left, HMMIO right) => !left.Equals(right);
    public static implicit operator nint(HMMIO value) => value.Value;
    public static implicit operator HMMIO(nint value) => new(value);
    
    readonly nint IValueGet<nint>.GetValue() => Value;
    readonly object? IValueGet.GetValue() => Value;
}
