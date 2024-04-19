namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmpservices/nn-wmpservices-iwmptranscodepolicy
[GeneratedComInterface, Guid("b64cbac3-401c-4327-a3e8-b9feb3a8c25c")]
public partial interface IWMPTranscodePolicy
{
    // https://learn.microsoft.com/windows/win32/api/wmpservices/nf-wmpservices-iwmptranscodepolicy-allowtranscode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT allowTranscode(ref VARIANT_BOOL pvbAllow);
}
