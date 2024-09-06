#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/msopc/nn-msopc-iopcuri
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("bc9c1b9b-d62c-49eb-aef0-3b4e0b28ebed")]
public partial interface IOpcUri : IUri
{
    // https://learn.microsoft.com/windows/win32/api/msopc/nf-msopc-iopcuri-getrelationshipsparturi
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRelationshipsPartUri([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IOpcPartUri>))] out IOpcPartUri relationshipPartUri);
    
    // https://learn.microsoft.com/windows/win32/api/msopc/nf-msopc-iopcuri-getrelativeuri
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRelativeUri(IOpcPartUri targetPartUri, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IUri>))] out IUri relativeUri);
    
    // https://learn.microsoft.com/windows/win32/api/msopc/nf-msopc-iopcuri-combineparturi
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CombinePartUri(IUri relativeUri, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IOpcPartUri>))] out IOpcPartUri combinedUri);
}
