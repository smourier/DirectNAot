#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/audioendpoints/nn-audioendpoints-iaudioendpointformatcontrol
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("784cfd40-9f89-456e-a1a6-873b006a664e")]
public partial interface IAudioEndpointFormatControl
{
    // https://learn.microsoft.com/windows/win32/api/audioendpoints/nf-audioendpoints-iaudioendpointformatcontrol-resettodefault
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ResetToDefault(uint ResetFlags);
}
