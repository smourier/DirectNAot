#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/msopc/nn-msopc-iopccertificateset
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("56ea4325-8e2d-4167-b1a4-e486d24c8fa7")]
public partial interface IOpcCertificateSet
{
    // https://learn.microsoft.com/windows/win32/api/msopc/nf-msopc-iopccertificateset-add
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Add(in CERT_CONTEXT certificate);
    
    // https://learn.microsoft.com/windows/win32/api/msopc/nf-msopc-iopccertificateset-remove
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Remove(in CERT_CONTEXT certificate);
    
    // https://learn.microsoft.com/windows/win32/api/msopc/nf-msopc-iopccertificateset-getenumerator
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEnumerator([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IOpcCertificateEnumerator>))] out IOpcCertificateEnumerator certificateEnumerator);
}
