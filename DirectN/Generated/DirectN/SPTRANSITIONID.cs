#nullable enable
namespace DirectN;

public partial struct SPTRANSITIONID : IEquatable<SPTRANSITIONID>, IValueGet<nint>
{
    public static readonly SPTRANSITIONID Null = new();
    
    public nint Value;
    
    public SPTRANSITIONID(nint value) => this.Value = value;
    public override readonly string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is SPTRANSITIONID value && Equals(value);
    public readonly bool Equals(SPTRANSITIONID other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(SPTRANSITIONID left, SPTRANSITIONID right) => left.Equals(right);
    public static bool operator !=(SPTRANSITIONID left, SPTRANSITIONID right) => !left.Equals(right);
    public static implicit operator nint(SPTRANSITIONID value) => value.Value;
    public static implicit operator SPTRANSITIONID(nint value) => new(value);
    
    readonly nint IValueGet<nint>.GetValue() => Value;
    readonly object? IValueGet.GetValue() => Value;
}
