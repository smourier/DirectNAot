namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1_3/nn-d2d1_3-id2d1gdimetafile1
[SupportedOSPlatform("windows10.0.10240")]
[GeneratedComInterface, Guid("2e69f9e8-dd3f-4bf9-95ba-c04f49d788df")]
public partial interface ID2D1GdiMetafile1 : ID2D1GdiMetafile
{
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1gdimetafile1-getdpi
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetDpi(out float dpiX, out float dpiY);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1gdimetafile1-getsourcebounds
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetSourceBounds(out D2D_RECT_F bounds);
}
