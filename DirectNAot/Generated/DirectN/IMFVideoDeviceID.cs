namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/evr/nn-evr-imfvideodeviceid
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("a38d9567-5a9c-4f3c-b293-8eb415b279ba")]
public partial interface IMFVideoDeviceID
{
    // https://learn.microsoft.com/windows/win32/api/evr/nf-evr-imfvideodeviceid-getdeviceid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDeviceID(out Guid pDeviceID);
}
