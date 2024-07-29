#nullable enable
namespace DirectN;

public partial struct DHPDEV : IEquatable<DHPDEV>
{
    public static readonly DHPDEV Null = new();
    
    public nint Value;
    
    public DHPDEV(nint value) => this.Value = value;
    public override string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is DHPDEV value && Equals(value);
    public readonly bool Equals(DHPDEV other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(DHPDEV left, DHPDEV right) => left.Equals(right);
    public static bool operator !=(DHPDEV left, DHPDEV right) => !left.Equals(right);
    public static implicit operator nint(DHPDEV value) => value.Value;
    public static implicit operator DHPDEV(nint value) => new(value);
}
