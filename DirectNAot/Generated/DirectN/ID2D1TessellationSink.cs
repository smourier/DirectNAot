namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1/nn-d2d1-id2d1tessellationsink
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("2cd906c1-12e2-11dc-9fed-001143a055f9")]
public partial interface ID2D1TessellationSink
{
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1tessellationsink-addtriangles
    [PreserveSig]
    void AddTriangles([MarshalUsing(CountElementName = nameof(trianglesCount))] in D2D1_TRIANGLE[] triangles, uint trianglesCount);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1tessellationsink-close
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Close();
}
