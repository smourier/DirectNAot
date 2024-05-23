#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/msopc/nn-msopc-iopcparturi
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("7d3babe7-88b2-46ba-85cb-4203cb016c87")]
public partial interface IOpcPartUri : IOpcUri
{
    // https://learn.microsoft.com/windows/win32/api/msopc/nf-msopc-iopcparturi-compareparturi
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ComparePartUri(IOpcPartUri partUri, out int comparisonResult);
    
    // https://learn.microsoft.com/windows/win32/api/msopc/nf-msopc-iopcparturi-getsourceuri
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSourceUri([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IOpcUri>))] out IOpcUri sourceUri);
    
    // https://learn.microsoft.com/windows/win32/api/msopc/nf-msopc-iopcparturi-isrelationshipsparturi
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsRelationshipsPartUri([MarshalAs(UnmanagedType.U4)] out bool isRelationshipUri);
}
