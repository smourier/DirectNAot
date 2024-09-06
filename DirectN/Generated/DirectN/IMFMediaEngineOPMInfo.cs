#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfmediaengine/nn-mfmediaengine-imfmediaengineopminfo
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("765763e6-6c01-4b01-bb0f-b829f60ed28c")]
public partial interface IMFMediaEngineOPMInfo
{
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengineopminfo-getopminfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOPMInfo(out MF_MEDIA_ENGINE_OPM_STATUS pStatus, out BOOL pConstricted);
}
