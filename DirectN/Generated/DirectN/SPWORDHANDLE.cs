#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct SPWORDHANDLE : IEquatable<SPWORDHANDLE>
{
    public static readonly SPWORDHANDLE Null = new();
    
    public nint Value;
    
    public override readonly bool Equals(object? obj) => obj is SPWORDHANDLE value && Equals(value);
    public readonly bool Equals(SPWORDHANDLE other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(SPWORDHANDLE left, SPWORDHANDLE right) => left.Equals(right);
    public static bool operator !=(SPWORDHANDLE left, SPWORDHANDLE right) => !left.Equals(right);
}
