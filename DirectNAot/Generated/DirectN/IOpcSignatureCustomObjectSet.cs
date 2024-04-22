namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/msopc/nn-msopc-iopcsignaturecustomobjectset
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("8f792ac5-7947-4e11-bc3d-2659ff046ae1")]
public partial interface IOpcSignatureCustomObjectSet
{
    // https://learn.microsoft.com/windows/win32/api/msopc/nf-msopc-iopcsignaturecustomobjectset-create
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Create(nint /* byte array */ xmlMarkup, uint count, out IOpcSignatureCustomObject customObject);
    
    // https://learn.microsoft.com/windows/win32/api/msopc/nf-msopc-iopcsignaturecustomobjectset-delete
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Delete(IOpcSignatureCustomObject customObject);
    
    // https://learn.microsoft.com/windows/win32/api/msopc/nf-msopc-iopcsignaturecustomobjectset-getenumerator
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEnumerator(out IOpcSignatureCustomObjectEnumerator customObjectEnumerator);
}
