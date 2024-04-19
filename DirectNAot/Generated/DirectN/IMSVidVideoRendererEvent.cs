namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/segment/nn-segment-imsvidvideorendererevent
[GeneratedComInterface, Guid("37b03545-a4c8-11d2-b634-00c04f79498e")]
public partial interface IMSVidVideoRendererEvent : IMSVidOutputDeviceEvent
{
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidvideorendererevent-overlayunavailable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OverlayUnavailable();
}
