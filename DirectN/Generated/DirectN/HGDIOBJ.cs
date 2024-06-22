#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct HGDIOBJ : IEquatable<HGDIOBJ>
{
    public static readonly HGDIOBJ Null = new();
    
    public nint Value;
    
    public override readonly bool Equals(object? obj) => obj is HGDIOBJ value && Equals(value);
    public readonly bool Equals(HGDIOBJ other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HGDIOBJ left, HGDIOBJ right) => left.Equals(right);
    public static bool operator !=(HGDIOBJ left, HGDIOBJ right) => !left.Equals(right);
}
