#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1_1/nn-d2d1_1-id2d1gdimetafile
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("2f543dc3-cfc1-4211-864f-cfd91c6f3395")]
public partial interface ID2D1GdiMetafile : ID2D1Resource
{
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1gdimetafile-stream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Stream(ID2D1GdiMetafileSink sink);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1gdimetafile-getbounds
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBounds(out D2D_RECT_F bounds);
}
