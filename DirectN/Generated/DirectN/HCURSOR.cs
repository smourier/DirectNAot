#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct HCURSOR : IEquatable<HCURSOR>
{
    public static readonly HCURSOR Null = new();
    
    public nint Value;
    
    public override readonly bool Equals(object? obj) => obj is HCURSOR value && Equals(value);
    public readonly bool Equals(HCURSOR other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HCURSOR left, HCURSOR right) => left.Equals(right);
    public static bool operator !=(HCURSOR left, HCURSOR right) => !left.Equals(right);
}
