namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/austream/nn-austream-iaudiostreamsample
[GeneratedComInterface, Guid("345fee00-aba5-11d0-8212-00c04fc32c45")]
public partial interface IAudioStreamSample : IStreamSample
{
    // https://learn.microsoft.com/windows/win32/api/austream/nf-austream-iaudiostreamsample-getaudiodata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAudioData(out IAudioData ppAudio);
}
