#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct HMMIO : IEquatable<HMMIO>
{
    public static readonly HMMIO Null = new();
    
    public nint Value;
    
    public override readonly bool Equals(object? obj) => obj is HMMIO value && Equals(value);
    public readonly bool Equals(HMMIO other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HMMIO left, HMMIO right) => left.Equals(right);
    public static bool operator !=(HMMIO left, HMMIO right) => !left.Equals(right);
}
