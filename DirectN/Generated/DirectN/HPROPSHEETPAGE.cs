#nullable enable
namespace DirectN;

public partial struct HPROPSHEETPAGE : IEquatable<HPROPSHEETPAGE>
{
    public static readonly HPROPSHEETPAGE Null = new();
    
    public nint Value;
    
    public override readonly bool Equals(object? obj) => obj is HPROPSHEETPAGE value && Equals(value);
    public readonly bool Equals(HPROPSHEETPAGE other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HPROPSHEETPAGE left, HPROPSHEETPAGE right) => left.Equals(right);
    public static bool operator !=(HPROPSHEETPAGE left, HPROPSHEETPAGE right) => !left.Equals(right);
}
