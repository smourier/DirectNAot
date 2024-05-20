#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-idrawvideoimage
[GeneratedComInterface, Guid("48efb120-ab49-11d2-aed2-00a0c995e8d5")]
public partial interface IDrawVideoImage
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idrawvideoimage-drawvideoimagebegin
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DrawVideoImageBegin();
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idrawvideoimage-drawvideoimageend
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DrawVideoImageEnd();
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idrawvideoimage-drawvideoimagedraw
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DrawVideoImageDraw(HDC hdc, in RECT lprcSrc, in RECT lprcDst);
}
