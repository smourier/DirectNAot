namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1/nn-d2d1-id2d1pathgeometry
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("2cd906a5-12e2-11dc-9fed-001143a055f9")]
public partial interface ID2D1PathGeometry : ID2D1Geometry
{
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1pathgeometry-open
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Open(out ID2D1GeometrySink geometrySink);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1pathgeometry-stream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Stream(ID2D1GeometrySink geometrySink);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1pathgeometry-getsegmentcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetSegmentCount(out uint count);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1pathgeometry-getfigurecount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetFigureCount(out uint count);
}
