#nullable enable
namespace DirectN;

public partial struct SPSERIALIZEDRESULT : IEquatable<SPSERIALIZEDRESULT>
{
    public static readonly SPSERIALIZEDRESULT Null = new();
    
    public uint ulSerializedSize;
    
    public SPSERIALIZEDRESULT(uint value) => this.ulSerializedSize = value;
    public override string ToString() => $"0x{ulSerializedSize:x}";
    
    public override readonly bool Equals(object? obj) => obj is SPSERIALIZEDRESULT value && Equals(value);
    public readonly bool Equals(SPSERIALIZEDRESULT other) => other.ulSerializedSize == ulSerializedSize;
    public override readonly int GetHashCode() => ulSerializedSize.GetHashCode();
    public static bool operator ==(SPSERIALIZEDRESULT left, SPSERIALIZEDRESULT right) => left.Equals(right);
    public static bool operator !=(SPSERIALIZEDRESULT left, SPSERIALIZEDRESULT right) => !left.Equals(right);
    public static implicit operator uint(SPSERIALIZEDRESULT value) => value.ulSerializedSize;
    public static implicit operator SPSERIALIZEDRESULT(uint value) => new(value);
}
