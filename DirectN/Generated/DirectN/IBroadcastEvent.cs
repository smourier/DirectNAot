#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tuner/nn-tuner-ibroadcastevent
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("3b21263f-26e8-489d-aac4-924f7efd9511")]
public partial interface IBroadcastEvent
{
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ibroadcastevent-fire
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Fire(Guid EventID);
}
