#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/segment/nn-segment-imsvidrect
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("7f5000a6-a440-47ca-8acc-c0e75531a2c2")]
public partial interface IMSVidRect : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidrect-get_top
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Top(out int TopVal);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidrect-put_top
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Top(int TopVal);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidrect-get_left
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Left(out int LeftVal);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidrect-put_left
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Left(int LeftVal);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidrect-get_width
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Width(out int WidthVal);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidrect-put_width
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Width(int WidthVal);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidrect-get_height
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Height(out int HeightVal);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidrect-put_height
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Height(int HeightVal);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidrect-get_hwnd
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_HWnd(out HWND HWndVal);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidrect-put_hwnd
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_HWnd(HWND HWndVal);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidrect-put_rect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Rect(IMSVidRect RectVal);
}
