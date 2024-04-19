namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/encdec/nn-encdec-idtfilterconfig
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("c4c4c4d2-0049-4e2b-98fb-9537f6ce516d")]
public partial interface IDTFilterConfig
{
    // https://learn.microsoft.com/windows/win32/api/encdec/nf-encdec-idtfilterconfig-getsecurechannelobject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSecureChannelObject(out nint ppUnkDRMSecureChannel);
}
