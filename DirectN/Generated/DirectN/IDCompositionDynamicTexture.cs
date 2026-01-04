#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("a1de1d3f-6405-447f-8e95-1383a34b0277")]
public partial interface IDCompositionDynamicTexture
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTexture([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDCompositionTexture>))] IDCompositionTexture pTexture, [In][MarshalUsing(CountElementName = nameof(rectCount))] RECT[] pRects, nuint rectCount);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTexture([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDCompositionTexture>))] IDCompositionTexture pTexture);
}
