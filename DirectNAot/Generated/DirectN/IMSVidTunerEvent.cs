namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/segment/nn-segment-imsvidtunerevent
[GeneratedComInterface, Guid("1c15d485-911d-11d2-b632-00c04f79498e")]
public partial interface IMSVidTunerEvent : IMSVidInputDeviceEvent
{
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidtunerevent-tunechanged
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TuneChanged(IMSVidTuner lpd);
}
