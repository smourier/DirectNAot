namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1_3/nn-d2d1_3-id2d1svgglyphstyle
[GeneratedComInterface, Guid("af671749-d241-4db8-8e41-dcc2e5c1a438")]
public partial interface ID2D1SvgGlyphStyle : ID2D1Resource
{
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1svgglyphstyle-setfill
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetFill(ID2D1Brush brush);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1svgglyphstyle-getfill
    [PreserveSig]
    public void GetFill(out ID2D1Brush brush);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1svgglyphstyle-setstroke
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetStroke(ID2D1Brush brush, float strokeWidth, nint/* nint */ dashes, uint dashesCount, float dashOffset);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1svgglyphstyle-getstrokedashescount
    [PreserveSig]
    public uint GetStrokeDashesCount();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1svgglyphstyle-getstroke
    [PreserveSig]
    public void GetStroke(nint/* nint */ brush, nint/* nint */ strokeWidth, nint/* nint */ dashes, uint dashesCount, nint/* nint */ dashOffset);
}
