#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/msopc/nn-msopc-iopcsignaturereference
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("1b47005e-3011-4edc-be6f-0f65e5ab0342")]
public partial interface IOpcSignatureReference
{
    // https://learn.microsoft.com/windows/win32/api/msopc/nf-msopc-iopcsignaturereference-getid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetId(out PWSTR referenceId);
    
    // https://learn.microsoft.com/windows/win32/api/msopc/nf-msopc-iopcsignaturereference-geturi
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetUri(out IUri referenceUri);
    
    // https://learn.microsoft.com/windows/win32/api/msopc/nf-msopc-iopcsignaturereference-gettype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetType(out PWSTR type);
    
    // https://learn.microsoft.com/windows/win32/api/msopc/nf-msopc-iopcsignaturereference-gettransformmethod
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTransformMethod(out OPC_CANONICALIZATION_METHOD transformMethod);
    
    // https://learn.microsoft.com/windows/win32/api/msopc/nf-msopc-iopcsignaturereference-getdigestmethod
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDigestMethod(out PWSTR digestMethod);
    
    // https://learn.microsoft.com/windows/win32/api/msopc/nf-msopc-iopcsignaturereference-getdigestvalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDigestValue(out nint /* byte array */ digestValue, out uint count);
}
