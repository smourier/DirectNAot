#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/amxmlgraphbuilder/nn-amxmlgraphbuilder-ixmlgraphbuilder
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("1bb05960-5fbf-11d2-a521-44df07c10000")]
public partial interface IXMLGraphBuilder
{
    // https://learn.microsoft.com/windows/win32/api/amxmlgraphbuilder/nf-amxmlgraphbuilder-ixmlgraphbuilder-buildfromxml
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BuildFromXML([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IGraphBuilder>))] IGraphBuilder pGraph, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXMLElement>))] IXMLElement pxml);
    
    // https://learn.microsoft.com/windows/win32/api/amxmlgraphbuilder/nf-amxmlgraphbuilder-ixmlgraphbuilder-savetoxml
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SaveToXML([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IGraphBuilder>))] IGraphBuilder pGraph, out BSTR pbstrxml);
    
    // https://learn.microsoft.com/windows/win32/api/amxmlgraphbuilder/nf-amxmlgraphbuilder-ixmlgraphbuilder-buildfromxmlfile
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BuildFromXMLFile([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IGraphBuilder>))] IGraphBuilder pGraph, PWSTR wszFileName, PWSTR wszBaseURL);
}
