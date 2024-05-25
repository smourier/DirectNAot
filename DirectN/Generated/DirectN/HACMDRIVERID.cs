#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct HACMDRIVERID : IEquatable<HACMDRIVERID>
{
    public static readonly HACMDRIVERID Null = new();
    
    public nint Value;
    
    public override readonly bool Equals(object? obj) => obj is HACMDRIVERID value && Equals(value);
    public readonly bool Equals(HACMDRIVERID other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HACMDRIVERID left, HACMDRIVERID right) => left.Equals(right);
    public static bool operator !=(HACMDRIVERID left, HACMDRIVERID right) => !left.Equals(right);
}
