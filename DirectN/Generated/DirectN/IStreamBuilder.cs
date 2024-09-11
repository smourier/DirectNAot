#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-istreambuilder
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("56a868bf-0ad4-11ce-b03a-0020af0ba770")]
public partial interface IStreamBuilder
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-istreambuilder-render
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Render([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPin>))] IPin ppinOut, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IGraphBuilder>))] IGraphBuilder pGraph);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-istreambuilder-backout
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Backout([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPin>))] IPin ppinOut, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IGraphBuilder>))] IGraphBuilder pGraph);
}
