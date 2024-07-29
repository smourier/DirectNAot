#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/audioclient/nn-audioclient-iaudiorenderclient
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("f294acfc-3146-4483-a7bf-addca7c260e2")]
public partial interface IAudioRenderClient
{
    // https://learn.microsoft.com/windows/win32/api/audioclient/nf-audioclient-iaudiorenderclient-getbuffer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBuffer(uint NumFramesRequested, out nint /* byte array */ ppData);
    
    // https://learn.microsoft.com/windows/win32/api/audioclient/nf-audioclient-iaudiorenderclient-releasebuffer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReleaseBuffer(uint NumFramesWritten, uint dwFlags);
}
