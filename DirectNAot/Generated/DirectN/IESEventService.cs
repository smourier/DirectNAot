namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tuner/nn-tuner-ieseventservice
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("ed89a619-4c06-4b2f-99eb-c7669b13047c")]
public partial interface IESEventService
{
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ieseventservice-fireesevent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FireESEvent(IESEvent? pESEvent);
}
