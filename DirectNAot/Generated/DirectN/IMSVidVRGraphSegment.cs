namespace DirectN;

[GeneratedComInterface, Guid("dd47de3f-9874-4f7b-8b22-7cb2688461e7")]
public partial interface IMSVidVRGraphSegment : IMSVidGraphSegment
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put__VMRendererMode(int dwMode);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Owner(HWND Window);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Owner(out HWND Window);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_UseOverlay(out VARIANT_BOOL UseOverlayVal);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_UseOverlay(VARIANT_BOOL UseOverlayVal);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Visible(out VARIANT_BOOL Visible);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Visible(VARIANT_BOOL Visible);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ColorKey(out uint ColorKey);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_ColorKey(uint ColorKey);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Source(out FoundationRECT r);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Source(FoundationRECT r);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Destination(out FoundationRECT r);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Destination(FoundationRECT r);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_NativeSize(out FoundationSIZE sizeval, out FoundationSIZE aspectratio);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_BorderColor(out uint color);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_BorderColor(uint color);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_MaintainAspectRatio(out VARIANT_BOOL fMaintain);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_MaintainAspectRatio(VARIANT_BOOL fMaintain);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Refresh();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DisplayChange();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RePaint(HDC hdc);
}
