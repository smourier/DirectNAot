#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/bdaiface/nn-bdaiface-ibda_easmessage
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("d806973d-3ebe-46de-8fbb-6358fe784208")]
public partial interface IBDA_EasMessage
{
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_easmessage-get_easmessage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_EasMessage(uint ulEventID, ref nint ppEASObject);
}
