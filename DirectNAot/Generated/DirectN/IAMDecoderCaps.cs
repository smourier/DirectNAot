namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-iamdecodercaps
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("c0dff467-d499-4986-972b-e1d9090fa941")]
public partial interface IAMDecoderCaps
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamdecodercaps-getdecodercaps
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDecoderCaps(uint dwCapIndex, out uint lpdwCap);
}
