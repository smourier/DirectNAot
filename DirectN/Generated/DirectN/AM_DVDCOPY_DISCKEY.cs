#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dvdmedia/ns-dvdmedia-am_dvdcopy_disckey
public partial struct AM_DVDCOPY_DISCKEY : IValueGet<byte[]>
{
    public InlineArrayByte_2048 DiscKey;
    
    readonly byte[]? IValueGet<byte[]>.GetValue() => ((ReadOnlySpan<byte>)DiscKey).ToArray();
    readonly object? IValueGet.GetValue() => ((ReadOnlySpan<byte>)DiscKey).ToArray();
}
