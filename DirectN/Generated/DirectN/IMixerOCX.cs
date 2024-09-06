#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mixerocx/nn-mixerocx-imixerocx
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("81a3bd32-dee1-11d1-8508-00a0c91f9ca0")]
public partial interface IMixerOCX
{
    // https://learn.microsoft.com/windows/win32/api/mixerocx/nf-mixerocx-imixerocx-ondisplaychange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnDisplayChange(uint ulBitsPerPixel, uint ulScreenWidth, uint ulScreenHeight);
    
    // https://learn.microsoft.com/windows/win32/api/mixerocx/nf-mixerocx-imixerocx-getaspectratio
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAspectRatio(out uint pdwPictAspectRatioX, out uint pdwPictAspectRatioY);
    
    // https://learn.microsoft.com/windows/win32/api/mixerocx/nf-mixerocx-imixerocx-getvideosize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVideoSize(out uint pdwVideoWidth, out uint pdwVideoHeight);
    
    // https://learn.microsoft.com/windows/win32/api/mixerocx/nf-mixerocx-imixerocx-getstatus
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStatus(out nint pdwStatus);
    
    // https://learn.microsoft.com/windows/win32/api/mixerocx/nf-mixerocx-imixerocx-ondraw
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnDraw(HDC hdcDraw, in RECT prcDraw);
    
    // https://learn.microsoft.com/windows/win32/api/mixerocx/nf-mixerocx-imixerocx-setdrawregion
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDrawRegion(in POINT lpptTopLeftSC, in RECT prcDrawCC, in RECT lprcClip);
    
    // https://learn.microsoft.com/windows/win32/api/mixerocx/nf-mixerocx-imixerocx-advise
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Advise(IMixerOCXNotify pmdns);
    
    // https://learn.microsoft.com/windows/win32/api/mixerocx/nf-mixerocx-imixerocx-unadvise
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnAdvise();
}
