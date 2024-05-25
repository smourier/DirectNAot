#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct HMIXEROBJ : IEquatable<HMIXEROBJ>
{
    public static readonly HMIXEROBJ Null = new();
    
    public nint Value;
    
    public override readonly bool Equals(object? obj) => obj is HMIXEROBJ value && Equals(value);
    public readonly bool Equals(HMIXEROBJ other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HMIXEROBJ left, HMIXEROBJ right) => left.Equals(right);
    public static bool operator !=(HMIXEROBJ left, HMIXEROBJ right) => !left.Equals(right);
}
