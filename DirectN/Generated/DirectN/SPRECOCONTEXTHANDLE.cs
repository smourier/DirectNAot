#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct SPRECOCONTEXTHANDLE : IEquatable<SPRECOCONTEXTHANDLE>
{
    public static readonly SPRECOCONTEXTHANDLE Null = new();
    
    public nint Value;
    
    public override readonly bool Equals(object? obj) => obj is SPRECOCONTEXTHANDLE value && Equals(value);
    public readonly bool Equals(SPRECOCONTEXTHANDLE other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(SPRECOCONTEXTHANDLE left, SPRECOCONTEXTHANDLE right) => left.Equals(right);
    public static bool operator !=(SPRECOCONTEXTHANDLE left, SPRECOCONTEXTHANDLE right) => !left.Equals(right);
}
