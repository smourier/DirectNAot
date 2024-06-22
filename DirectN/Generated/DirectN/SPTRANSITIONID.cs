#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct SPTRANSITIONID : IEquatable<SPTRANSITIONID>
{
    public static readonly SPTRANSITIONID Null = new();
    
    public nint Value;
    
    public override readonly bool Equals(object? obj) => obj is SPTRANSITIONID value && Equals(value);
    public readonly bool Equals(SPTRANSITIONID other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(SPTRANSITIONID left, SPTRANSITIONID right) => left.Equals(right);
    public static bool operator !=(SPTRANSITIONID left, SPTRANSITIONID right) => !left.Equals(right);
}
