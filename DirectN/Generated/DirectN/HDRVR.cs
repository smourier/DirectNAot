#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct HDRVR : IEquatable<HDRVR>
{
    public static readonly HDRVR Null = new();
    
    public nint Value;
    
    public override readonly bool Equals(object? obj) => obj is HDRVR value && Equals(value);
    public readonly bool Equals(HDRVR other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HDRVR left, HDRVR right) => left.Equals(right);
    public static bool operator !=(HDRVR left, HDRVR right) => !left.Equals(right);
}
