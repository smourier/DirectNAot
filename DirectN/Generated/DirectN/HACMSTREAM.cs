#nullable enable
namespace DirectN;

public partial struct HACMSTREAM : IEquatable<HACMSTREAM>
{
    public static readonly HACMSTREAM Null = new();
    
    public nint Value;
    
    public HACMSTREAM(nint value) => this.Value = value;
    public override string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is HACMSTREAM value && Equals(value);
    public readonly bool Equals(HACMSTREAM other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HACMSTREAM left, HACMSTREAM right) => left.Equals(right);
    public static bool operator !=(HACMSTREAM left, HACMSTREAM right) => !left.Equals(right);
    public static implicit operator nint(HACMSTREAM value) => value.Value;
    public static implicit operator HACMSTREAM(nint value) => new(value);
}
