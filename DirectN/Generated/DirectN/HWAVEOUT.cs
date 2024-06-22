#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct HWAVEOUT : IEquatable<HWAVEOUT>
{
    public static readonly HWAVEOUT Null = new();
    
    public nint Value;
    
    public override readonly bool Equals(object? obj) => obj is HWAVEOUT value && Equals(value);
    public readonly bool Equals(HWAVEOUT other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HWAVEOUT left, HWAVEOUT right) => left.Equals(right);
    public static bool operator !=(HWAVEOUT left, HWAVEOUT right) => !left.Equals(right);
}
