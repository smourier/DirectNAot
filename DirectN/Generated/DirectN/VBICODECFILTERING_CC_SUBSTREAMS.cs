#nullable enable
namespace DirectN;

public partial struct VBICODECFILTERING_CC_SUBSTREAMS : IEquatable<VBICODECFILTERING_CC_SUBSTREAMS>, IValueGet<uint>
{
    public static readonly VBICODECFILTERING_CC_SUBSTREAMS Null = new();
    
    public uint SubstreamMask;
    
    public VBICODECFILTERING_CC_SUBSTREAMS(uint value) => this.SubstreamMask = value;
    public override readonly string ToString() => $"0x{SubstreamMask:x}";
    
    public override readonly bool Equals(object? obj) => obj is VBICODECFILTERING_CC_SUBSTREAMS value && Equals(value);
    public readonly bool Equals(VBICODECFILTERING_CC_SUBSTREAMS other) => other.SubstreamMask == SubstreamMask;
    public override readonly int GetHashCode() => SubstreamMask.GetHashCode();
    public static bool operator ==(VBICODECFILTERING_CC_SUBSTREAMS left, VBICODECFILTERING_CC_SUBSTREAMS right) => left.Equals(right);
    public static bool operator !=(VBICODECFILTERING_CC_SUBSTREAMS left, VBICODECFILTERING_CC_SUBSTREAMS right) => !left.Equals(right);
    public static implicit operator uint(VBICODECFILTERING_CC_SUBSTREAMS value) => value.SubstreamMask;
    public static implicit operator VBICODECFILTERING_CC_SUBSTREAMS(uint value) => new(value);
    
    readonly uint IValueGet<uint>.GetValue() => SubstreamMask;
    readonly object? IValueGet.GetValue() => SubstreamMask;
}
