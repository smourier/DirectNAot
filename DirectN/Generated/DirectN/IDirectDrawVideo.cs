#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/amvideo/nn-amvideo-idirectdrawvideo
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("36d39eb0-dd75-11ce-bf0e-00aa0055595a")]
public partial interface IDirectDrawVideo
{
    // https://learn.microsoft.com/windows/win32/api/amvideo/nf-amvideo-idirectdrawvideo-getswitches
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSwitches(out uint pSwitches);
    
    // https://learn.microsoft.com/windows/win32/api/amvideo/nf-amvideo-idirectdrawvideo-setswitches
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSwitches(uint Switches);
    
    // https://learn.microsoft.com/windows/win32/api/amvideo/nf-amvideo-idirectdrawvideo-getcaps
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCaps(out DDCAPS_DX7 pCaps);
    
    // https://learn.microsoft.com/windows/win32/api/amvideo/nf-amvideo-idirectdrawvideo-getemulatedcaps
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEmulatedCaps(out DDCAPS_DX7 pCaps);
    
    // https://learn.microsoft.com/windows/win32/api/amvideo/nf-amvideo-idirectdrawvideo-getsurfacedesc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSurfaceDesc(ref DDSURFACEDESC pSurfaceDesc);
    
    // https://learn.microsoft.com/windows/win32/api/amvideo/nf-amvideo-idirectdrawvideo-getfourcccodes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFourCCCodes(out uint pCount, out uint pCodes);
    
    // https://learn.microsoft.com/windows/win32/api/amvideo/nf-amvideo-idirectdrawvideo-setdirectdraw
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDirectDraw(IDirectDraw pDirectDraw);
    
    // https://learn.microsoft.com/windows/win32/api/amvideo/nf-amvideo-idirectdrawvideo-getdirectdraw
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDirectDraw([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirectDraw>))] out IDirectDraw ppDirectDraw);
    
    // https://learn.microsoft.com/windows/win32/api/amvideo/nf-amvideo-idirectdrawvideo-getsurfacetype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSurfaceType(out uint pSurfaceType);
    
    // https://learn.microsoft.com/windows/win32/api/amvideo/nf-amvideo-idirectdrawvideo-setdefault
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDefault();
    
    // https://learn.microsoft.com/windows/win32/api/amvideo/nf-amvideo-idirectdrawvideo-usescanline
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UseScanLine(int UseScanLine);
    
    // https://learn.microsoft.com/windows/win32/api/amvideo/nf-amvideo-idirectdrawvideo-canusescanline
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CanUseScanLine(out int UseScanLine);
    
    // https://learn.microsoft.com/windows/win32/api/amvideo/nf-amvideo-idirectdrawvideo-useoverlaystretch
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UseOverlayStretch(int UseOverlayStretch);
    
    // https://learn.microsoft.com/windows/win32/api/amvideo/nf-amvideo-idirectdrawvideo-canuseoverlaystretch
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CanUseOverlayStretch(out int UseOverlayStretch);
    
    // https://learn.microsoft.com/windows/win32/api/amvideo/nf-amvideo-idirectdrawvideo-usewhenfullscreen
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UseWhenFullScreen(int UseWhenFullScreen);
    
    // https://learn.microsoft.com/windows/win32/api/amvideo/nf-amvideo-idirectdrawvideo-willusefullscreen
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT WillUseFullScreen(out int UseWhenFullScreen);
}
