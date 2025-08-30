#nullable enable
namespace DirectN;

public partial struct SPSERIALIZEDPHRASE : IEquatable<SPSERIALIZEDPHRASE>, IValueGet<uint>
{
    public static readonly SPSERIALIZEDPHRASE Null = new();
    
    public uint ulSerializedSize;
    
    public SPSERIALIZEDPHRASE(uint value) => this.ulSerializedSize = value;
    public override string ToString() => $"0x{ulSerializedSize:x}";
    
    public override readonly bool Equals(object? obj) => obj is SPSERIALIZEDPHRASE value && Equals(value);
    public readonly bool Equals(SPSERIALIZEDPHRASE other) => other.ulSerializedSize == ulSerializedSize;
    public override readonly int GetHashCode() => ulSerializedSize.GetHashCode();
    public static bool operator ==(SPSERIALIZEDPHRASE left, SPSERIALIZEDPHRASE right) => left.Equals(right);
    public static bool operator !=(SPSERIALIZEDPHRASE left, SPSERIALIZEDPHRASE right) => !left.Equals(right);
    public static implicit operator uint(SPSERIALIZEDPHRASE value) => value.ulSerializedSize;
    public static implicit operator SPSERIALIZEDPHRASE(uint value) => new(value);
    
    readonly uint IValueGet<uint>.GetValue() => ulSerializedSize;
    readonly object? IValueGet.GetValue() => ulSerializedSize;
}
