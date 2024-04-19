namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-iamaudiorendererstats
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("22320cb2-d41a-11d2-bf7c-d7cb9df0bf93")]
public partial interface IAMAudioRendererStats
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamaudiorendererstats-getstatparam
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStatParam(uint dwParam, out uint pdwParam1, out uint pdwParam2);
}
