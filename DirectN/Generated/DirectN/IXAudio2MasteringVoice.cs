#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xaudio2/nn-xaudio2-ixaudio2masteringvoice
[GeneratedComInterface, Guid("00000000-0000-0000-0000-000000000000")]
public partial interface IXAudio2MasteringVoice : IXAudio2Voice
{
    // https://learn.microsoft.com/windows/win32/api/xaudio2/nf-xaudio2-ixaudio2masteringvoice-getchannelmask
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetChannelMask(out uint pChannelmask);
}
