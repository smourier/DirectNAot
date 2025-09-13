#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmp/nn-wmp-iwmperroritem
[GeneratedComInterface, Guid("3614c646-3b3b-4de7-a81e-930e3f2127b3")]
public partial interface IWMPErrorItem : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmperroritem-get_errorcode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_errorCode(ref int phr);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmperroritem-get_errordescription
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_errorDescription(out BSTR pbstrDescription);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmperroritem-get_errorcontext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_errorContext(ref VARIANT pvarContext);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmperroritem-get_remedy
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_remedy(ref int plRemedy);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmperroritem-get_customurl
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_customUrl(out BSTR pbstrCustomUrl);
}
