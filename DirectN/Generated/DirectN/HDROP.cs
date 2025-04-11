#nullable enable
namespace DirectN;

public partial struct HDROP : IEquatable<HDROP>
{
    public static readonly HDROP Null = new();
    
    public nint Value;
    
    public HDROP(nint value) => this.Value = value;
    public override string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is HDROP value && Equals(value);
    public readonly bool Equals(HDROP other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HDROP left, HDROP right) => left.Equals(right);
    public static bool operator !=(HDROP left, HDROP right) => !left.Equals(right);
    public static implicit operator nint(HDROP value) => value.Value;
    public static implicit operator HDROP(nint value) => new(value);
}
