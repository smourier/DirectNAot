#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/audiopolicy/nn-audiopolicy-iaudiosessioncontrol2
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("bfb7ff88-7239-4fc9-8fa2-07c950be9c6d")]
public partial interface IAudioSessionControl2 : IAudioSessionControl
{
    // https://learn.microsoft.com/windows/win32/api/audiopolicy/nf-audiopolicy-iaudiosessioncontrol2-getsessionidentifier
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSessionIdentifier(out PWSTR pRetVal);
    
    // https://learn.microsoft.com/windows/win32/api/audiopolicy/nf-audiopolicy-iaudiosessioncontrol2-getsessioninstanceidentifier
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSessionInstanceIdentifier(out PWSTR pRetVal);
    
    // https://learn.microsoft.com/windows/win32/api/audiopolicy/nf-audiopolicy-iaudiosessioncontrol2-getprocessid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProcessId(out uint pRetVal);
    
    // https://learn.microsoft.com/windows/win32/api/audiopolicy/nf-audiopolicy-iaudiosessioncontrol2-issystemsoundssession
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsSystemSoundsSession();
    
    // https://learn.microsoft.com/windows/win32/api/audiopolicy/nf-audiopolicy-iaudiosessioncontrol2-setduckingpreference
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDuckingPreference([MarshalAs(UnmanagedType.U4)] bool optOut);
}
