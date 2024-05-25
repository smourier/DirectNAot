#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct SPPHRASERULEHANDLE : IEquatable<SPPHRASERULEHANDLE>
{
    public static readonly SPPHRASERULEHANDLE Null = new();
    
    public nint Value;
    
    public override readonly bool Equals(object? obj) => obj is SPPHRASERULEHANDLE value && Equals(value);
    public readonly bool Equals(SPPHRASERULEHANDLE other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(SPPHRASERULEHANDLE left, SPPHRASERULEHANDLE right) => left.Equals(right);
    public static bool operator !=(SPPHRASERULEHANDLE left, SPPHRASERULEHANDLE right) => !left.Equals(right);
}
