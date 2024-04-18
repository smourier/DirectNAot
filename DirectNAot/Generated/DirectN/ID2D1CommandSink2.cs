namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1_3/nn-d2d1_3-id2d1commandsink2
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("3bab440e-417e-47df-a2e2-bc0be6a00916")]
public partial interface ID2D1CommandSink2 : ID2D1CommandSink1
{
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1commandsink2-drawink
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT DrawInk(ID2D1Ink ink, ID2D1Brush brush, ID2D1InkStyle inkStyle);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1commandsink2-drawgradientmesh
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT DrawGradientMesh(ID2D1GradientMesh gradientMesh);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1commandsink2-drawgdimetafile
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT DrawGdiMetafile(ID2D1GdiMetafile gdiMetafile, nint/* nint */ destinationRectangle, nint/* nint */ sourceRectangle);
}
