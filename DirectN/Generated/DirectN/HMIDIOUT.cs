#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct HMIDIOUT : IEquatable<HMIDIOUT>
{
    public static readonly HMIDIOUT Null = new();
    
    public nint Value;
    
    public override readonly bool Equals(object? obj) => obj is HMIDIOUT value && Equals(value);
    public readonly bool Equals(HMIDIOUT other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HMIDIOUT left, HMIDIOUT right) => left.Equals(right);
    public static bool operator !=(HMIDIOUT left, HMIDIOUT right) => !left.Equals(right);
}
