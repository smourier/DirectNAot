#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dvdmedia/ns-dvdmedia-am_dvdcopy_set_copy_state
public partial struct AM_DVDCOPY_SET_COPY_STATE : IEquatable<AM_DVDCOPY_SET_COPY_STATE>, IValueGet<uint>
{
    public static readonly AM_DVDCOPY_SET_COPY_STATE Null = new();
    
    public uint DVDCopyState;
    
    public AM_DVDCOPY_SET_COPY_STATE(uint value) => this.DVDCopyState = value;
    public override string ToString() => $"0x{DVDCopyState:x}";
    
    public override readonly bool Equals(object? obj) => obj is AM_DVDCOPY_SET_COPY_STATE value && Equals(value);
    public readonly bool Equals(AM_DVDCOPY_SET_COPY_STATE other) => other.DVDCopyState == DVDCopyState;
    public override readonly int GetHashCode() => DVDCopyState.GetHashCode();
    public static bool operator ==(AM_DVDCOPY_SET_COPY_STATE left, AM_DVDCOPY_SET_COPY_STATE right) => left.Equals(right);
    public static bool operator !=(AM_DVDCOPY_SET_COPY_STATE left, AM_DVDCOPY_SET_COPY_STATE right) => !left.Equals(right);
    public static implicit operator uint(AM_DVDCOPY_SET_COPY_STATE value) => value.DVDCopyState;
    public static implicit operator AM_DVDCOPY_SET_COPY_STATE(uint value) => new(value);
    
    readonly uint IValueGet<uint>.GetValue() => DVDCopyState;
    readonly object? IValueGet.GetValue() => DVDCopyState;
}
