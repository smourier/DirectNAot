#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/msopc/nn-msopc-iopcsignaturereferenceenumerator
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("cfa59a45-28b1-4868-969e-fa8097fdc12a")]
public partial interface IOpcSignatureReferenceEnumerator
{
    // https://learn.microsoft.com/windows/win32/api/msopc/nf-msopc-iopcsignaturereferenceenumerator-movenext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MoveNext(out BOOL hasNext);
    
    // https://learn.microsoft.com/windows/win32/api/msopc/nf-msopc-iopcsignaturereferenceenumerator-moveprevious
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MovePrevious(out BOOL hasPrevious);
    
    // https://learn.microsoft.com/windows/win32/api/msopc/nf-msopc-iopcsignaturereferenceenumerator-getcurrent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrent([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IOpcSignatureReference>))] out IOpcSignatureReference reference);
    
    // https://learn.microsoft.com/windows/win32/api/msopc/nf-msopc-iopcsignaturereferenceenumerator-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IOpcSignatureReferenceEnumerator>))] out IOpcSignatureReferenceEnumerator copy);
}
