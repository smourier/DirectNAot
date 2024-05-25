#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct SPSTATEHANDLE : IEquatable<SPSTATEHANDLE>
{
    public static readonly SPSTATEHANDLE Null = new();
    
    public nint Value;
    
    public override readonly bool Equals(object? obj) => obj is SPSTATEHANDLE value && Equals(value);
    public readonly bool Equals(SPSTATEHANDLE other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(SPSTATEHANDLE left, SPSTATEHANDLE right) => left.Equals(right);
    public static bool operator !=(SPSTATEHANDLE left, SPSTATEHANDLE right) => !left.Equals(right);
}
