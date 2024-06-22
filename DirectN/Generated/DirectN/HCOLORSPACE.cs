#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct HCOLORSPACE : IEquatable<HCOLORSPACE>
{
    public static readonly HCOLORSPACE Null = new();
    
    public nint Value;
    
    public override readonly bool Equals(object? obj) => obj is HCOLORSPACE value && Equals(value);
    public readonly bool Equals(HCOLORSPACE other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HCOLORSPACE left, HCOLORSPACE right) => left.Equals(right);
    public static bool operator !=(HCOLORSPACE left, HCOLORSPACE right) => !left.Equals(right);
}
