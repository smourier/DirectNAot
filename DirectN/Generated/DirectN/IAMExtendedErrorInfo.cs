#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/qnetwork/nn-qnetwork-iamextendederrorinfo
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("fa2aa8f6-8b62-11d0-a520-000000000000")]
public partial interface IAMExtendedErrorInfo : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iamextendederrorinfo-get_haserror
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_HasError(ref VARIANT_BOOL pHasError);
    
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iamextendederrorinfo-get_errordescription
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ErrorDescription(ref BSTR pbstrErrorDescription);
    
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iamextendederrorinfo-get_errorcode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ErrorCode(ref int pErrorCode);
}
