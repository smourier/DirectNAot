#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/sbe/nn-sbe-istreambuffersink3
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("974723f2-887a-4452-9366-2cff3057bc8f")]
public partial interface IStreamBufferSink3 : IStreamBufferSink2
{
    // https://learn.microsoft.com/windows/win32/api/sbe/nf-sbe-istreambuffersink3-setavailablefilter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAvailableFilter(ref long prtMin);
}
