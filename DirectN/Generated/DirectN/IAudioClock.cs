#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/audioclient/nn-audioclient-iaudioclock
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("cd63314f-3fba-4a1b-812c-ef96358728e7")]
public partial interface IAudioClock
{
    // https://learn.microsoft.com/windows/win32/api/audioclient/nf-audioclient-iaudioclock-getfrequency
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFrequency(out ulong pu64Frequency);
    
    // https://learn.microsoft.com/windows/win32/api/audioclient/nf-audioclient-iaudioclock-getposition
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPosition(out ulong pu64Position, nint /* optional ulong* */ pu64QPCPosition);
    
    // https://learn.microsoft.com/windows/win32/api/audioclient/nf-audioclient-iaudioclock-getcharacteristics
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCharacteristics(out uint pdwCharacteristics);
}
