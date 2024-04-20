namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1_3/nn-d2d1_3-id2d1svgglyphstyle
[GeneratedComInterface, Guid("af671749-d241-4db8-8e41-dcc2e5c1a438")]
public partial interface ID2D1SvgGlyphStyle : ID2D1Resource
{
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1svgglyphstyle-setfill
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFill(ID2D1Brush brush);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1svgglyphstyle-getfill
    [PreserveSig]
    void GetFill(out ID2D1Brush brush);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1svgglyphstyle-setstroke
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetStroke(ID2D1Brush brush, float strokeWidth, nint /* optional float */ dashes, uint dashesCount, float dashOffset);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1svgglyphstyle-getstrokedashescount
    [PreserveSig]
    uint GetStrokeDashesCount();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1svgglyphstyle-getstroke
    [PreserveSig]
    void GetStroke(nint /* optional ID2D1Brush */ brush, nint /* optional float */ strokeWidth, nint /* optional float */ dashes, uint dashesCount, nint /* optional float */ dashOffset);
}
