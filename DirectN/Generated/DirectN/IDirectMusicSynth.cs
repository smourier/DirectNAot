#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dmusics/nn-dmusics-idirectmusicsynth
[GeneratedComInterface, Guid("09823661-5c85-11d2-afa6-00aa0024d8b6")]
public partial interface IDirectMusicSynth
{
    // https://learn.microsoft.com/windows/win32/api/dmusics/nf-dmusics-idirectmusicsynth-open
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Open(ref DMUS_PORTPARAMS8 pPortParams);
    
    // https://learn.microsoft.com/windows/win32/api/dmusics/nf-dmusics-idirectmusicsynth-close
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Close();
    
    // https://learn.microsoft.com/windows/win32/api/dmusics/nf-dmusics-idirectmusicsynth-setnumchannelgroups
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetNumChannelGroups(uint dwGroups);
    
    // https://learn.microsoft.com/windows/win32/api/dmusics/nf-dmusics-idirectmusicsynth-download
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Download(ref HANDLE phDownload, nint pvData, [MarshalAs(UnmanagedType.U4)] ref bool pbFree);
    
    // https://learn.microsoft.com/windows/win32/api/dmusics/nf-dmusics-idirectmusicsynth-unload
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Unload(HANDLE hDownload, nint lpFreeHandle, HANDLE hUserData);
    
    // https://learn.microsoft.com/windows/win32/api/dmusics/nf-dmusics-idirectmusicsynth-playbuffer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PlayBuffer(long rt, nint /* byte array */ pbBuffer, uint cbBuffer);
    
    // https://learn.microsoft.com/windows/win32/api/dmusics/nf-dmusics-idirectmusicsynth-getrunningstats
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRunningStats(ref DMUS_SYNTHSTATS pStats);
    
    // https://learn.microsoft.com/windows/win32/api/dmusics/nf-dmusics-idirectmusicsynth-getportcaps
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPortCaps(ref DMUS_PORTCAPS pCaps);
    
    // https://learn.microsoft.com/windows/win32/api/dmusics/nf-dmusics-idirectmusicsynth-setmasterclock
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetMasterClock(IReferenceClock pClock);
    
    // https://learn.microsoft.com/windows/win32/api/dmusics/nf-dmusics-idirectmusicsynth-getlatencyclock
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLatencyClock([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IReferenceClock>))] out IReferenceClock ppClock);
    
    // https://learn.microsoft.com/windows/win32/api/dmusics/nf-dmusics-idirectmusicsynth-activate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Activate([MarshalAs(UnmanagedType.U4)] bool fEnable);
    
    // https://learn.microsoft.com/windows/win32/api/dmusics/nf-dmusics-idirectmusicsynth-setsynthsink
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSynthSink(IDirectMusicSynthSink pSynthSink);
    
    // https://learn.microsoft.com/windows/win32/api/dmusics/nf-dmusics-idirectmusicsynth-render
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Render(ref short pBuffer, uint dwLength, long llPosition);
    
    // https://learn.microsoft.com/windows/win32/api/dmusics/nf-dmusics-idirectmusicsynth-setchannelpriority
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetChannelPriority(uint dwChannelGroup, uint dwChannel, uint dwPriority);
    
    // https://learn.microsoft.com/windows/win32/api/dmusics/nf-dmusics-idirectmusicsynth-getchannelpriority
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetChannelPriority(uint dwChannelGroup, uint dwChannel, ref uint pdwPriority);
    
    // https://learn.microsoft.com/windows/win32/api/dmusics/nf-dmusics-idirectmusicsynth-getformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFormat(ref WAVEFORMATEX pWaveFormatEx, ref uint pdwWaveFormatExSize);
    
    // https://learn.microsoft.com/windows/win32/api/dmusics/nf-dmusics-idirectmusicsynth-getappend
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAppend(ref uint pdwAppend);
}
