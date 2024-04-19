namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/audioengineextensionapo/nn-audioengineextensionapo-iaudioprocessingobjectloggingservice
[GeneratedComInterface, Guid("698f0107-1745-4708-95a5-d84478a62a65")]
public partial interface IAudioProcessingObjectLoggingService
{
    // https://learn.microsoft.com/windows/win32/api/audioengineextensionapo/nf-audioengineextensionapo-iaudioprocessingobjectloggingservice-apolog
    [PreserveSig]
    void ApoLog(APO_LOG_LEVEL level, PWSTR format);
}
