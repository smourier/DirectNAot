namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-iseekingpassthru
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("36b73883-c2c8-11cf-8b46-00805f6cef60")]
public partial interface ISeekingPassThru
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iseekingpassthru-init
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Init([MarshalAs(UnmanagedType.U4)] bool bSupportRendering, IPin pPin);
}
