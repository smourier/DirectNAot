namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nn-d2d1effectauthor-id2d1sourcetransform
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("db1800dd-0c34-4cf9-be90-31cc0a5653e1")]
public partial interface ID2D1SourceTransform : ID2D1Transform
{
    // https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nf-d2d1effectauthor-id2d1sourcetransform-setrenderinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetRenderInfo(ID2D1RenderInfo renderInfo);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nf-d2d1effectauthor-id2d1sourcetransform-draw
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Draw(ID2D1Bitmap1 target, in RECT drawRect, D2D_POINT_2U targetOrigin);
}
