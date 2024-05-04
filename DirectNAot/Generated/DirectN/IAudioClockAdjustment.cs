#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/audioclient/nn-audioclient-iaudioclockadjustment
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("f6e4c0a0-46d9-4fb8-be21-57a3ef2b626c")]
public partial interface IAudioClockAdjustment
{
    // https://learn.microsoft.com/windows/win32/api/audioclient/nf-audioclient-iaudioclockadjustment-setsamplerate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSampleRate(float flSampleRate);
}
