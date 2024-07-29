#nullable enable
namespace DirectN;

public partial struct KS_COPY_MACROVISION : IEquatable<KS_COPY_MACROVISION>
{
    public static readonly KS_COPY_MACROVISION Null = new();
    
    public uint MACROVISIONLevel;
    
    public KS_COPY_MACROVISION(uint value) => this.MACROVISIONLevel = value;
    public override string ToString() => $"0x{MACROVISIONLevel:x}";
    
    public override readonly bool Equals(object? obj) => obj is KS_COPY_MACROVISION value && Equals(value);
    public readonly bool Equals(KS_COPY_MACROVISION other) => other.MACROVISIONLevel == MACROVISIONLevel;
    public override readonly int GetHashCode() => MACROVISIONLevel.GetHashCode();
    public static bool operator ==(KS_COPY_MACROVISION left, KS_COPY_MACROVISION right) => left.Equals(right);
    public static bool operator !=(KS_COPY_MACROVISION left, KS_COPY_MACROVISION right) => !left.Equals(right);
    public static implicit operator uint(KS_COPY_MACROVISION value) => value.MACROVISIONLevel;
    public static implicit operator KS_COPY_MACROVISION(uint value) => new(value);
}
