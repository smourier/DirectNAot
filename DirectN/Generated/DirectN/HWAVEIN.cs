#nullable enable
namespace DirectN;

public partial struct HWAVEIN : IEquatable<HWAVEIN>, IValueGet<nint>
{
    public static readonly HWAVEIN Null = new();
    
    public nint Value;
    
    public HWAVEIN(nint value) => this.Value = value;
    public override readonly string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is HWAVEIN value && Equals(value);
    public readonly bool Equals(HWAVEIN other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HWAVEIN left, HWAVEIN right) => left.Equals(right);
    public static bool operator !=(HWAVEIN left, HWAVEIN right) => !left.Equals(right);
    public static implicit operator nint(HWAVEIN value) => value.Value;
    public static implicit operator HWAVEIN(nint value) => new(value);
    
    readonly nint IValueGet<nint>.GetValue() => Value;
    readonly object? IValueGet.GetValue() => Value;
}
