#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dvdmedia/ns-dvdmedia-am_property_sppal
public partial struct AM_PROPERTY_SPPAL : IValueGet<AM_DVD_YUV[]>
{
    public InlineArrayAM_DVD_YUV_16 sppal;
    
    readonly AM_DVD_YUV[]? IValueGet<AM_DVD_YUV[]>.GetValue() => ((ReadOnlySpan<AM_DVD_YUV>)sppal).ToArray();
    readonly object? IValueGet.GetValue() => ((ReadOnlySpan<AM_DVD_YUV>)sppal).ToArray();
}
