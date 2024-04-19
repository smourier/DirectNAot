namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/nn-wincodec-iwicdeveloprawnotificationcallback
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("95c75a6e-3e8c-4ec2-85a8-aebcc551e59b")]
public partial interface IWICDevelopRawNotificationCallback
{
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicdeveloprawnotificationcallback-notify
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Notify(uint NotificationMask);
}
