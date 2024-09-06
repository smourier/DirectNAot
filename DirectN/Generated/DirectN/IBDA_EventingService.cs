#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/bdaiface/nn-bdaiface-ibda_eventingservice
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("207c413f-00dc-4c61-bad6-6fee1ff07064")]
public partial interface IBDA_EventingService
{
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_eventingservice-completeevent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CompleteEvent(uint ulEventID, uint ulEventResult);
}
