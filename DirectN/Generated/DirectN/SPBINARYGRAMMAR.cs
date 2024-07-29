#nullable enable
namespace DirectN;

public partial struct SPBINARYGRAMMAR : IEquatable<SPBINARYGRAMMAR>
{
    public static readonly SPBINARYGRAMMAR Null = new();
    
    public uint ulTotalSerializedSize;
    
    public SPBINARYGRAMMAR(uint value) => this.ulTotalSerializedSize = value;
    public override string ToString() => $"0x{ulTotalSerializedSize:x}";
    
    public override readonly bool Equals(object? obj) => obj is SPBINARYGRAMMAR value && Equals(value);
    public readonly bool Equals(SPBINARYGRAMMAR other) => other.ulTotalSerializedSize == ulTotalSerializedSize;
    public override readonly int GetHashCode() => ulTotalSerializedSize.GetHashCode();
    public static bool operator ==(SPBINARYGRAMMAR left, SPBINARYGRAMMAR right) => left.Equals(right);
    public static bool operator !=(SPBINARYGRAMMAR left, SPBINARYGRAMMAR right) => !left.Equals(right);
    public static implicit operator uint(SPBINARYGRAMMAR value) => value.ulTotalSerializedSize;
    public static implicit operator SPBINARYGRAMMAR(uint value) => new(value);
}
