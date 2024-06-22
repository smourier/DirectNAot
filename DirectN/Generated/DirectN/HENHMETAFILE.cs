#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct HENHMETAFILE : IEquatable<HENHMETAFILE>
{
    public static readonly HENHMETAFILE Null = new();
    
    public nint Value;
    
    public override readonly bool Equals(object? obj) => obj is HENHMETAFILE value && Equals(value);
    public readonly bool Equals(HENHMETAFILE other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HENHMETAFILE left, HENHMETAFILE right) => left.Equals(right);
    public static bool operator !=(HENHMETAFILE left, HENHMETAFILE right) => !left.Equals(right);
}
