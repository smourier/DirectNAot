#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfseekinfo
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("26afea53-d9ed-42b5-ab80-e64f9ee34779")]
public partial interface IMFSeekInfo
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfseekinfo-getnearestkeyframes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNearestKeyFrames(in Guid pguidTimeFormat, in PROPVARIANT pvarStartPosition, out PROPVARIANT pvarPreviousKeyFrame, out PROPVARIANT pvarNextKeyFrame);
}
