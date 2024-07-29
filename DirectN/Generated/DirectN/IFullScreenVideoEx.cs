#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/amvideo/nn-amvideo-ifullscreenvideoex
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("53479470-f1dd-11cf-bc42-00aa00ac74f6")]
public partial interface IFullScreenVideoEx : IFullScreenVideo
{
    // https://learn.microsoft.com/windows/win32/api/amvideo/nf-amvideo-ifullscreenvideoex-setacceleratortable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAcceleratorTable(HWND hwnd, HACCEL hAccel);
    
    // https://learn.microsoft.com/windows/win32/api/amvideo/nf-amvideo-ifullscreenvideoex-getacceleratortable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAcceleratorTable(out HWND phwnd, ref HACCEL phAccel);
    
    // https://learn.microsoft.com/windows/win32/api/amvideo/nf-amvideo-ifullscreenvideoex-keeppixelaspectratio
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT KeepPixelAspectRatio(int KeepAspect);
    
    // https://learn.microsoft.com/windows/win32/api/amvideo/nf-amvideo-ifullscreenvideoex-iskeeppixelaspectratio
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsKeepPixelAspectRatio(out int pKeepAspect);
}
