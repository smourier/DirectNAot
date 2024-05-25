#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct HKEY : IEquatable<HKEY>
{
    public static readonly HKEY Null = new();
    
    public nint Value;
    
    public override readonly bool Equals(object? obj) => obj is HKEY value && Equals(value);
    public readonly bool Equals(HKEY other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HKEY left, HKEY right) => left.Equals(right);
    public static bool operator !=(HKEY left, HKEY right) => !left.Equals(right);
}
