#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DHPDEV : IEquatable<DHPDEV>
{
    public static readonly DHPDEV Null = new();
    
    public nint Value;
    
    public override readonly bool Equals(object? obj) => obj is DHPDEV value && Equals(value);
    public readonly bool Equals(DHPDEV other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(DHPDEV left, DHPDEV right) => left.Equals(right);
    public static bool operator !=(DHPDEV left, DHPDEV right) => !left.Equals(right);
}
