#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct HWND : IEquatable<HWND>
{
    public static readonly HWND Null = new();
    
    public nint Value;
    
    public override readonly bool Equals(object? obj) => obj is HWND value && Equals(value);
    public readonly bool Equals(HWND other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HWND left, HWND right) => left.Equals(right);
    public static bool operator !=(HWND left, HWND right) => !left.Equals(right);
}
