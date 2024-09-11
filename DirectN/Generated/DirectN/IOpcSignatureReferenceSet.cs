#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/msopc/nn-msopc-iopcsignaturereferenceset
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("f3b02d31-ab12-42dd-9e2f-2b16761c3c1e")]
public partial interface IOpcSignatureReferenceSet
{
    // https://learn.microsoft.com/windows/win32/api/msopc/nf-msopc-iopcsignaturereferenceset-create
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Create([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IUri>))] IUri referenceUri, PWSTR referenceId, PWSTR type, PWSTR digestMethod, OPC_CANONICALIZATION_METHOD transformMethod, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IOpcSignatureReference>))] out IOpcSignatureReference reference);
    
    // https://learn.microsoft.com/windows/win32/api/msopc/nf-msopc-iopcsignaturereferenceset-delete
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Delete([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IOpcSignatureReference>))] IOpcSignatureReference reference);
    
    // https://learn.microsoft.com/windows/win32/api/msopc/nf-msopc-iopcsignaturereferenceset-getenumerator
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEnumerator([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IOpcSignatureReferenceEnumerator>))] out IOpcSignatureReferenceEnumerator referenceEnumerator);
}
