namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1svg/nn-d2d1svg-id2d1svgpaint
[GeneratedComInterface, Guid("d59bab0a-68a2-455b-a5dc-9eb2854e2490")]
public partial interface ID2D1SvgPaint : ID2D1SvgAttribute
{
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgpaint-setpainttype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetPaintType(D2D1_SVG_PAINT_TYPE paintType);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgpaint-getpainttype
    [PreserveSig]
    public D2D1_SVG_PAINT_TYPE GetPaintType();
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1svgpaint-setcolor-overload
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetColor(in D2D1_COLOR_F color);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgpaint-getcolor
    [PreserveSig]
    public void GetColor(out D2D1_COLOR_F color);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgpaint-setid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetId(PWSTR id);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgpaint-getid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetId(out PWSTR id, uint idCount);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgpaint-getidlength
    [PreserveSig]
    public uint GetIdLength();
}
