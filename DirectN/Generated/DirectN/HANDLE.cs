#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct HANDLE : IEquatable<HANDLE>
{
    public static readonly HANDLE Null = new();
    
    public nint Value;
    
    public override readonly bool Equals(object? obj) => obj is HANDLE value && Equals(value);
    public readonly bool Equals(HANDLE other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HANDLE left, HANDLE right) => left.Equals(right);
    public static bool operator !=(HANDLE left, HANDLE right) => !left.Equals(right);
}
