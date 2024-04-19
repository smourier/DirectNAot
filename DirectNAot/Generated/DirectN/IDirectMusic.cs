namespace DirectN;

[GeneratedComInterface, Guid("6536115a-7b2d-11d2-ba18-0000f875ac12")]
public partial interface IDirectMusic
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumPort(uint dwIndex, ref DMUS_PORTCAPS pPortCaps);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateMusicBuffer(ref DMUS_BUFFERDESC pBufferDesc, out IDirectMusicBuffer ppBuffer, nint pUnkOuter);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreatePort(in Guid rclsidPort, ref DMUS_PORTPARAMS8 pPortParams, out IDirectMusicPort ppPort, nint pUnkOuter);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumMasterClock(uint dwIndex, ref DMUS_CLOCKINFO8 lpClockInfo);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMasterClock(ref Guid pguidClock, out IReferenceClock ppReferenceClock);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetMasterClock(in Guid rguidClock);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Activate([MarshalAs(UnmanagedType.U4)] bool fEnable);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDefaultPort(ref Guid pguidPort);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDirectSound(IDirectSound pDirectSound, HWND hWnd);
}
