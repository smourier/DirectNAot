#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/segment/nn-segment-imsviddeviceevent
[GeneratedComInterface, Guid("1c15d480-911d-11d2-b632-00c04f79498e")]
public partial interface IMSVidDeviceEvent : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsviddeviceevent-statechange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StateChange([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMSVidDevice>))] IMSVidDevice lpd, int oldState, int newState);
}
