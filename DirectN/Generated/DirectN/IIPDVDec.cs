#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-iipdvdec
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("b8e8bd60-0bfe-11d0-af91-00aa00b67a42")]
public partial interface IIPDVDec
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iipdvdec-get_ipdisplay
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_IPDisplay(out int displayPix);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iipdvdec-put_ipdisplay
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_IPDisplay(int displayPix);
}
