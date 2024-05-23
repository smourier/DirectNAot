#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/msopc/nn-msopc-iopcsignaturecustomobjectenumerator
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("5ee4fe1d-e1b0-4683-8079-7ea0fcf80b4c")]
public partial interface IOpcSignatureCustomObjectEnumerator
{
    // https://learn.microsoft.com/windows/win32/api/msopc/nf-msopc-iopcsignaturecustomobjectenumerator-movenext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MoveNext([MarshalAs(UnmanagedType.U4)] out bool hasNext);
    
    // https://learn.microsoft.com/windows/win32/api/msopc/nf-msopc-iopcsignaturecustomobjectenumerator-moveprevious
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MovePrevious([MarshalAs(UnmanagedType.U4)] out bool hasPrevious);
    
    // https://learn.microsoft.com/windows/win32/api/msopc/nf-msopc-iopcsignaturecustomobjectenumerator-getcurrent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrent([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IOpcSignatureCustomObject>))] out IOpcSignatureCustomObject customObject);
    
    // https://learn.microsoft.com/windows/win32/api/msopc/nf-msopc-iopcsignaturecustomobjectenumerator-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IOpcSignatureCustomObjectEnumerator>))] out IOpcSignatureCustomObjectEnumerator copy);
}
