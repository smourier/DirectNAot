#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct HDC : IEquatable<HDC>
{
    public static readonly HDC Null = new();
    
    public nint Value;
    
    public override readonly bool Equals(object? obj) => obj is HDC value && Equals(value);
    public readonly bool Equals(HDC other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HDC left, HDC right) => left.Equals(right);
    public static bool operator !=(HDC left, HDC right) => !left.Equals(right);
}
