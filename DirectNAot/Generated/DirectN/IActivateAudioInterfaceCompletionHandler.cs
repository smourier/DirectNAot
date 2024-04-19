namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mmdeviceapi/nn-mmdeviceapi-iactivateaudiointerfacecompletionhandler
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("41d949ab-9862-444a-80f6-c261334da5eb")]
public partial interface IActivateAudioInterfaceCompletionHandler
{
    // https://learn.microsoft.com/windows/win32/api/mmdeviceapi/nf-mmdeviceapi-iactivateaudiointerfacecompletionhandler-activatecompleted
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ActivateCompleted(IActivateAudioInterfaceAsyncOperation activateOperation);
}
