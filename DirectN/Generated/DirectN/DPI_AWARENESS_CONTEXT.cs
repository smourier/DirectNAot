#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DPI_AWARENESS_CONTEXT : IEquatable<DPI_AWARENESS_CONTEXT>
{
    public static readonly DPI_AWARENESS_CONTEXT Null = new();
    
    public nint Value;
    
    public override readonly bool Equals(object? obj) => obj is DPI_AWARENESS_CONTEXT value && Equals(value);
    public readonly bool Equals(DPI_AWARENESS_CONTEXT other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(DPI_AWARENESS_CONTEXT left, DPI_AWARENESS_CONTEXT right) => left.Equals(right);
    public static bool operator !=(DPI_AWARENESS_CONTEXT left, DPI_AWARENESS_CONTEXT right) => !left.Equals(right);
}
