#nullable enable
namespace DirectN;

public partial struct HRSRC : IEquatable<HRSRC>, IValueGet<nint>
{
    public static readonly HRSRC Null = new();
    
    public nint Value;
    
    public HRSRC(nint value) => this.Value = value;
    public override string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is HRSRC value && Equals(value);
    public readonly bool Equals(HRSRC other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HRSRC left, HRSRC right) => left.Equals(right);
    public static bool operator !=(HRSRC left, HRSRC right) => !left.Equals(right);
    public static implicit operator nint(HRSRC value) => value.Value;
    public static implicit operator HRSRC(nint value) => new(value);
    
    readonly nint IValueGet<nint>.GetValue() => Value;
    readonly object? IValueGet.GetValue() => Value;
}
