#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfobjects/nn-mfobjects-imfaudiomediatype
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("26a0adc3-ce26-4672-9304-69552edd3faf")]
public partial interface IMFAudioMediaType : IMFMediaType
{
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfaudiomediatype-getaudioformat
    [PreserveSig]
    nint GetAudioFormat();
}
