#nullable enable
namespace DirectN;

public partial struct KS_DVDCOPY_SET_COPY_STATE : IEquatable<KS_DVDCOPY_SET_COPY_STATE>, IValueGet<uint>
{
    public static readonly KS_DVDCOPY_SET_COPY_STATE Null = new();
    
    public uint DVDCopyState;
    
    public KS_DVDCOPY_SET_COPY_STATE(uint value) => this.DVDCopyState = value;
    public override string ToString() => $"0x{DVDCopyState:x}";
    
    public override readonly bool Equals(object? obj) => obj is KS_DVDCOPY_SET_COPY_STATE value && Equals(value);
    public readonly bool Equals(KS_DVDCOPY_SET_COPY_STATE other) => other.DVDCopyState == DVDCopyState;
    public override readonly int GetHashCode() => DVDCopyState.GetHashCode();
    public static bool operator ==(KS_DVDCOPY_SET_COPY_STATE left, KS_DVDCOPY_SET_COPY_STATE right) => left.Equals(right);
    public static bool operator !=(KS_DVDCOPY_SET_COPY_STATE left, KS_DVDCOPY_SET_COPY_STATE right) => !left.Equals(right);
    public static implicit operator uint(KS_DVDCOPY_SET_COPY_STATE value) => value.DVDCopyState;
    public static implicit operator KS_DVDCOPY_SET_COPY_STATE(uint value) => new(value);
    
    readonly uint IValueGet<uint>.GetValue() => DVDCopyState;
    readonly object? IValueGet.GetValue() => DVDCopyState;
}
