#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tuner/nn-tuner-iesevents
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("abd414bf-cfe5-4e5e-af5b-4b4e49c5bfeb")]
public partial interface IESEvents
{
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-iesevents-oneseventreceived
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnESEventReceived(Guid guidEventType, IESEvent pESEvent);
}
