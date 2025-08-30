#nullable enable
namespace DirectN;

public partial struct KSWAVE_COMPATCAPS : IEquatable<KSWAVE_COMPATCAPS>, IValueGet<uint>
{
    public static readonly KSWAVE_COMPATCAPS Null = new();
    
    public uint ulDeviceType;
    
    public KSWAVE_COMPATCAPS(uint value) => this.ulDeviceType = value;
    public override string ToString() => $"0x{ulDeviceType:x}";
    
    public override readonly bool Equals(object? obj) => obj is KSWAVE_COMPATCAPS value && Equals(value);
    public readonly bool Equals(KSWAVE_COMPATCAPS other) => other.ulDeviceType == ulDeviceType;
    public override readonly int GetHashCode() => ulDeviceType.GetHashCode();
    public static bool operator ==(KSWAVE_COMPATCAPS left, KSWAVE_COMPATCAPS right) => left.Equals(right);
    public static bool operator !=(KSWAVE_COMPATCAPS left, KSWAVE_COMPATCAPS right) => !left.Equals(right);
    public static implicit operator uint(KSWAVE_COMPATCAPS value) => value.ulDeviceType;
    public static implicit operator KSWAVE_COMPATCAPS(uint value) => new(value);
    
    readonly uint IValueGet<uint>.GetValue() => ulDeviceType;
    readonly object? IValueGet.GetValue() => ulDeviceType;
}
