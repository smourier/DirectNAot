#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/audiopolicy/nn-audiopolicy-iaudiosessionenumerator
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("e2f5bb11-0570-40ca-acdd-3aa01277dee8")]
public partial interface IAudioSessionEnumerator
{
    // https://learn.microsoft.com/windows/win32/api/audiopolicy/nf-audiopolicy-iaudiosessionenumerator-getcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCount(out int SessionCount);
    
    // https://learn.microsoft.com/windows/win32/api/audiopolicy/nf-audiopolicy-iaudiosessionenumerator-getsession
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSession(int SessionCount, out IAudioSessionControl Session);
}
