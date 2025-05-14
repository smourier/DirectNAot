#nullable enable
namespace DirectN;

public partial struct HFONT : IEquatable<HFONT>
{
    public static readonly HFONT Null = new();
    
    public nint Value;
    
    public HFONT(nint value) => this.Value = value;
    public override string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is HFONT value && Equals(value);
    public readonly bool Equals(HFONT other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HFONT left, HFONT right) => left.Equals(right);
    public static bool operator !=(HFONT left, HFONT right) => !left.Equals(right);
    public static implicit operator nint(HFONT value) => value.Value;
    public static implicit operator HFONT(nint value) => new(value);
}
