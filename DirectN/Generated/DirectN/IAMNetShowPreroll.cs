#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/qnetwork/nn-qnetwork-iamnetshowpreroll
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("aae7e4e2-6388-11d1-8d93-006097c9a2b2")]
public partial interface IAMNetShowPreroll : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iamnetshowpreroll-put_preroll
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Preroll(VARIANT_BOOL fPreroll);
    
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iamnetshowpreroll-get_preroll
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Preroll(ref VARIANT_BOOL pfPreroll);
}
