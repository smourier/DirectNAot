#nullable enable
namespace DirectN;

public partial struct HDEV : IEquatable<HDEV>
{
    public static readonly HDEV Null = new();
    
    public nint Value;
    
    public HDEV(nint value) => this.Value = value;
    public override string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is HDEV value && Equals(value);
    public readonly bool Equals(HDEV other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HDEV left, HDEV right) => left.Equals(right);
    public static bool operator !=(HDEV left, HDEV right) => !left.Equals(right);
    public static implicit operator nint(HDEV value) => value.Value;
    public static implicit operator HDEV(nint value) => new(value);
}
