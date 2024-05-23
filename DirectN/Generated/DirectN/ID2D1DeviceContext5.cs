#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1_3/nn-d2d1_3-id2d1devicecontext5
[GeneratedComInterface, Guid("7836d248-68cc-4df6-b9e8-de991bf62eb7")]
public partial interface ID2D1DeviceContext5 : ID2D1DeviceContext4
{
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1devicecontext5-createsvgdocument
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateSvgDocument(IStream? inputXmlStream, D2D_SIZE_F viewportSize, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1SvgDocument>))] out ID2D1SvgDocument svgDocument);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1devicecontext5-drawsvgdocument
    [PreserveSig]
    void DrawSvgDocument(ID2D1SvgDocument svgDocument);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1devicecontext5-createcolorcontextfromdxgicolorspace
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateColorContextFromDxgiColorSpace(DXGI_COLOR_SPACE_TYPE colorSpace, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1ColorContext1>))] out ID2D1ColorContext1 colorContext);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1devicecontext5-createcolorcontextfromsimplecolorprofile(constd2d1_simple_color_profile__id2d1colorcontext1)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateColorContextFromSimpleColorProfile(in D2D1_SIMPLE_COLOR_PROFILE simpleProfile, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1ColorContext1>))] out ID2D1ColorContext1 colorContext);
}
