namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/sbe/nn-sbe-istreambuffersink
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("afd1f242-7efd-45ee-ba4e-407a25c9a77a")]
public partial interface IStreamBufferSink
{
    // https://learn.microsoft.com/windows/win32/api/sbe/nf-sbe-istreambuffersink-lockprofile
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LockProfile(PWSTR pszStreamBufferFilename);
    
    // https://learn.microsoft.com/windows/win32/api/sbe/nf-sbe-istreambuffersink-createrecorder
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateRecorder(PWSTR pszFilename, uint dwRecordType, out nint pRecordingIUnknown);
    
    // https://learn.microsoft.com/windows/win32/api/sbe/nf-sbe-istreambuffersink-isprofilelocked
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsProfileLocked();
}
