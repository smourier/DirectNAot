#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xpsdigitalsignature/nn-xpsdigitalsignature-ixpssignatureblock
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("151fac09-0b97-4ac6-a323-5e4297d4322b")]
public partial interface IXpsSignatureBlock
{
    // https://learn.microsoft.com/windows/win32/api/xpsdigitalsignature/nf-xpsdigitalsignature-ixpssignatureblock-getrequests
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRequests([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsSignatureRequestCollection>))] out IXpsSignatureRequestCollection requests);
    
    // https://learn.microsoft.com/windows/win32/api/xpsdigitalsignature/nf-xpsdigitalsignature-ixpssignatureblock-getpartname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPartName([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IOpcPartUri>))] out IOpcPartUri partName);
    
    // https://learn.microsoft.com/windows/win32/api/xpsdigitalsignature/nf-xpsdigitalsignature-ixpssignatureblock-getdocumentindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDocumentIndex(out uint fixedDocumentIndex);
    
    // https://learn.microsoft.com/windows/win32/api/xpsdigitalsignature/nf-xpsdigitalsignature-ixpssignatureblock-getdocumentname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDocumentName([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IOpcPartUri>))] out IOpcPartUri fixedDocumentName);
    
    // https://learn.microsoft.com/windows/win32/api/xpsdigitalsignature/nf-xpsdigitalsignature-ixpssignatureblock-createrequest
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateRequest(PWSTR requestId, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsSignatureRequest>))] out IXpsSignatureRequest signatureRequest);
}
