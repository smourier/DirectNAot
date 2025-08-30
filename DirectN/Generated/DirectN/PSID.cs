#nullable enable
namespace DirectN;

public partial struct PSID : IEquatable<PSID>, IValueGet<nint>
{
    public static readonly PSID Null = new();
    
    public nint Value;
    
    public PSID(nint value) => this.Value = value;
    public override string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is PSID value && Equals(value);
    public readonly bool Equals(PSID other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(PSID left, PSID right) => left.Equals(right);
    public static bool operator !=(PSID left, PSID right) => !left.Equals(right);
    public static implicit operator nint(PSID value) => value.Value;
    public static implicit operator PSID(nint value) => new(value);
    
    readonly nint IValueGet<nint>.GetValue() => Value;
    readonly object? IValueGet.GetValue() => Value;
}
