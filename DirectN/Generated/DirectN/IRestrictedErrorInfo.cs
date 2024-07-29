#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/restrictederrorinfo/nn-restrictederrorinfo-irestrictederrorinfo
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("82ba7092-4c88-427d-a7bc-16dd93feb67e")]
public partial interface IRestrictedErrorInfo
{
    // https://learn.microsoft.com/windows/win32/api/restrictederrorinfo/nf-restrictederrorinfo-irestrictederrorinfo-geterrordetails
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetErrorDetails(out BSTR description, out HRESULT error, out BSTR restrictedDescription, out BSTR capabilitySid);
    
    // https://learn.microsoft.com/windows/win32/api/restrictederrorinfo/nf-restrictederrorinfo-irestrictederrorinfo-getreference
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetReference(out BSTR reference);
}
