#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct HCERTSTORE : IEquatable<HCERTSTORE>
{
    public static readonly HCERTSTORE Null = new();
    
    public nint Value;
    
    public override readonly bool Equals(object? obj) => obj is HCERTSTORE value && Equals(value);
    public readonly bool Equals(HCERTSTORE other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HCERTSTORE left, HCERTSTORE right) => left.Equals(right);
    public static bool operator !=(HCERTSTORE left, HCERTSTORE right) => !left.Equals(right);
}
