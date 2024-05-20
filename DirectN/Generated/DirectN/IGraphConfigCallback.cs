#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-igraphconfigcallback
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("ade0fd60-d19d-11d2-abf6-00a0c905f375")]
public partial interface IGraphConfigCallback
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-igraphconfigcallback-reconfigure
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Reconfigure(nint pvContext, uint dwFlags);
}
