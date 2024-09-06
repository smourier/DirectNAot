#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/segment/nn-segment-imsvidvideorendererevent2
[GeneratedComInterface, Guid("7145ed66-4730-4fdb-8a53-fde7508d3e5e")]
public partial interface IMSVidVideoRendererEvent2 : IMSVidOutputDeviceEvent
{
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidvideorendererevent2-overlayunavailable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OverlayUnavailable();
}
