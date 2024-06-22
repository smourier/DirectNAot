#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct PSID : IEquatable<PSID>
{
    public static readonly PSID Null = new();
    
    public nint Value;
    
    public override readonly bool Equals(object? obj) => obj is PSID value && Equals(value);
    public readonly bool Equals(PSID other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(PSID left, PSID right) => left.Equals(right);
    public static bool operator !=(PSID left, PSID right) => !left.Equals(right);
}
