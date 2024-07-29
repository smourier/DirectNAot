#nullable enable
namespace DirectN;

public partial struct CHAR : IEquatable<CHAR>
{
    public static readonly CHAR Null = new();
    
    public sbyte Value;
    
    public CHAR(sbyte value) => this.Value = value;
    public override string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is CHAR value && Equals(value);
    public readonly bool Equals(CHAR other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(CHAR left, CHAR right) => left.Equals(right);
    public static bool operator !=(CHAR left, CHAR right) => !left.Equals(right);
    public static implicit operator sbyte(CHAR value) => value.Value;
    public static implicit operator CHAR(sbyte value) => new(value);
}
