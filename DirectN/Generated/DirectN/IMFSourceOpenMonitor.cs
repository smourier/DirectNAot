#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfsourceopenmonitor
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("059054b3-027c-494c-a27d-9113291cf87f")]
public partial interface IMFSourceOpenMonitor
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsourceopenmonitor-onsourceevent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnSourceEvent(IMFMediaEvent pEvent);
}
