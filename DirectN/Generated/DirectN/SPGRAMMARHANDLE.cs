#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct SPGRAMMARHANDLE : IEquatable<SPGRAMMARHANDLE>
{
    public static readonly SPGRAMMARHANDLE Null = new();
    
    public nint Value;
    
    public override readonly bool Equals(object? obj) => obj is SPGRAMMARHANDLE value && Equals(value);
    public readonly bool Equals(SPGRAMMARHANDLE other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(SPGRAMMARHANDLE left, SPGRAMMARHANDLE right) => left.Equals(right);
    public static bool operator !=(SPGRAMMARHANDLE left, SPGRAMMARHANDLE right) => !left.Equals(right);
}
