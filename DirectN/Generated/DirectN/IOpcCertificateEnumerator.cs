#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/msopc/nn-msopc-iopccertificateenumerator
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("85131937-8f24-421f-b439-59ab24d140b8")]
public partial interface IOpcCertificateEnumerator
{
    // https://learn.microsoft.com/windows/win32/api/msopc/nf-msopc-iopccertificateenumerator-movenext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MoveNext([MarshalAs(UnmanagedType.U4)] out bool hasNext);
    
    // https://learn.microsoft.com/windows/win32/api/msopc/nf-msopc-iopccertificateenumerator-moveprevious
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MovePrevious([MarshalAs(UnmanagedType.U4)] out bool hasPrevious);
    
    // https://learn.microsoft.com/windows/win32/api/msopc/nf-msopc-iopccertificateenumerator-getcurrent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrent(out nint certificate);
    
    // https://learn.microsoft.com/windows/win32/api/msopc/nf-msopc-iopccertificateenumerator-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IOpcCertificateEnumerator>))] out IOpcCertificateEnumerator copy);
}
