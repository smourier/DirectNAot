#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct HDEV : IEquatable<HDEV>
{
    public static readonly HDEV Null = new();
    
    public nint Value;
    
    public override readonly bool Equals(object? obj) => obj is HDEV value && Equals(value);
    public readonly bool Equals(HDEV other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HDEV left, HDEV right) => left.Equals(right);
    public static bool operator !=(HDEV left, HDEV right) => !left.Equals(right);
}
