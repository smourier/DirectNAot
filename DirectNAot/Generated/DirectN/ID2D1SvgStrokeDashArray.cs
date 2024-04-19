namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1svg/nn-d2d1svg-id2d1svgstrokedasharray
[GeneratedComInterface, Guid("f1c0ca52-92a3-4f00-b4ce-f35691efd9d9")]
public partial interface ID2D1SvgStrokeDashArray : ID2D1SvgAttribute
{
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgstrokedasharray-removedashesatend
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveDashesAtEnd(uint dashesCount);
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1svgstrokedasharray-updatedashes-overload
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UpdateDashes(in D2D1_SVG_LENGTH dashes, uint dashesCount, uint startIndex);
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1svgstrokedasharray-updatedashes-overload
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UpdateDashes(in float dashes, uint dashesCount, uint startIndex);
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1svgstrokedasharray-getdashes-overload
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDashes(out D2D1_SVG_LENGTH dashes, uint dashesCount, uint startIndex);
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1svgstrokedasharray-getdashes-overload
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDashes(out float dashes, uint dashesCount, uint startIndex);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgstrokedasharray-getdashescount
    [PreserveSig]
    uint GetDashesCount();
}
