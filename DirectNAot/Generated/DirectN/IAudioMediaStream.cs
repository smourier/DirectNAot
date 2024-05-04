#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/austream/nn-austream-iaudiomediastream
[GeneratedComInterface, Guid("f7537560-a3be-11d0-8212-00c04fc32c45")]
public partial interface IAudioMediaStream : IMediaStream
{
    // https://learn.microsoft.com/windows/win32/api/austream/nf-austream-iaudiomediastream-getformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFormat(out WAVEFORMATEX pWaveFormatCurrent);
    
    // https://learn.microsoft.com/windows/win32/api/austream/nf-austream-iaudiomediastream-setformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFormat(in WAVEFORMATEX lpWaveFormat);
    
    // https://learn.microsoft.com/windows/win32/api/austream/nf-austream-iaudiomediastream-createsample
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateSample(IAudioData pAudioData, uint dwFlags, out IAudioStreamSample ppSample);
}
