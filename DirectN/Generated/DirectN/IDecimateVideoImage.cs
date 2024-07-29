#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-idecimatevideoimage
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("2e5ea3e0-e924-11d2-b6da-00a0c995e8df")]
public partial interface IDecimateVideoImage
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idecimatevideoimage-setdecimationimagesize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDecimationImageSize(int lWidth, int lHeight);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idecimatevideoimage-resetdecimationimagesize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ResetDecimationImageSize();
}
