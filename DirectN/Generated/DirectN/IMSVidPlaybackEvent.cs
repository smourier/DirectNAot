#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/segment/nn-segment-imsvidplaybackevent
[GeneratedComInterface, Guid("37b0353b-a4c8-11d2-b634-00c04f79498e")]
public partial interface IMSVidPlaybackEvent : IMSVidInputDeviceEvent
{
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidplaybackevent-endofmedia
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EndOfMedia([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMSVidPlayback>))] IMSVidPlayback lpd);
}
