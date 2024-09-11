#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1svg/nn-d2d1svg-id2d1svgdocument
[GeneratedComInterface, Guid("86b88e4d-afa4-4d7b-88e4-68a51c4a0aec")]
public partial interface ID2D1SvgDocument : ID2D1Resource
{
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgdocument-setviewportsize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetViewportSize(D2D_SIZE_F viewportSize);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgdocument-getviewportsize
    [PreserveSig]
    D2D_SIZE_F GetViewportSize();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgdocument-setroot
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRoot([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1SvgElement?>))] ID2D1SvgElement? root);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgdocument-getroot
    [PreserveSig]
    void GetRoot([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1SvgElement>))] out ID2D1SvgElement root);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgdocument-findelementbyid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindElementById(PWSTR id, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1SvgElement>))] out ID2D1SvgElement svgElement);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgdocument-serialize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Serialize([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IStream>))] IStream outputXmlStream, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1SvgElement?>))] ID2D1SvgElement? subtree);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgdocument-deserialize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Deserialize([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IStream>))] IStream inputXmlStream, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1SvgElement>))] out ID2D1SvgElement subtree);
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1svgdocument-createpaint-overload
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreatePaint(D2D1_SVG_PAINT_TYPE paintType, nint /* optional D3DCOLORVALUE* */ color, PWSTR id, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1SvgPaint>))] out ID2D1SvgPaint paint);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgdocument-createstrokedasharray
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateStrokeDashArray(nint /* optional D2D1_SVG_LENGTH* */ dashes, uint dashesCount, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1SvgStrokeDashArray>))] out ID2D1SvgStrokeDashArray strokeDashArray);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgdocument-createpointcollection
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreatePointCollection(nint /* optional D2D_POINT_2F* */ points, uint pointsCount, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1SvgPointCollection>))] out ID2D1SvgPointCollection pointCollection);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgdocument-createpathdata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreatePathData(nint /* optional float* */ segmentData, uint segmentDataCount, nint /* optional D2D1_SVG_PATH_COMMAND* */ commands, uint commandsCount, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1SvgPathData>))] out ID2D1SvgPathData pathData);
}
