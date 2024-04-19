namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/segment/nn-segment-imsvidevrevent
[GeneratedComInterface, Guid("349abb10-883c-4f22-8714-cecaeee45d62")]
public partial interface IMSVidEVREvent : IMSVidOutputDeviceEvent
{
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidevrevent-onuserevent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnUserEvent(int lEventCode);
}
