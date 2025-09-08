#nullable enable
namespace DirectN;

public partial struct VIDEO_REGISTER_VDM : IEquatable<VIDEO_REGISTER_VDM>, IValueGet<uint>
{
    public static readonly VIDEO_REGISTER_VDM Null = new();
    
    public uint MinimumStateSize;
    
    public VIDEO_REGISTER_VDM(uint value) => this.MinimumStateSize = value;
    public override readonly string ToString() => $"0x{MinimumStateSize:x}";
    
    public override readonly bool Equals(object? obj) => obj is VIDEO_REGISTER_VDM value && Equals(value);
    public readonly bool Equals(VIDEO_REGISTER_VDM other) => other.MinimumStateSize == MinimumStateSize;
    public override readonly int GetHashCode() => MinimumStateSize.GetHashCode();
    public static bool operator ==(VIDEO_REGISTER_VDM left, VIDEO_REGISTER_VDM right) => left.Equals(right);
    public static bool operator !=(VIDEO_REGISTER_VDM left, VIDEO_REGISTER_VDM right) => !left.Equals(right);
    public static implicit operator uint(VIDEO_REGISTER_VDM value) => value.MinimumStateSize;
    public static implicit operator VIDEO_REGISTER_VDM(uint value) => new(value);
    
    readonly uint IValueGet<uint>.GetValue() => MinimumStateSize;
    readonly object? IValueGet.GetValue() => MinimumStateSize;
}
