namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tuner/nn-tuner-itunercapex
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("ed3e0c66-18c8-4ea6-9300-f6841fdd35dc")]
public partial interface ITunerCapEx
{
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-itunercapex-get_has608_708caption
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Has608_708Caption(out VARIANT_BOOL pbHasCaption);
}
