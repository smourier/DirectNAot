#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("08f2d8c9-37c2-11d2-b9f9-0000f875ac12")]
public partial interface IDirectMusicPort
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PlayBuffer([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirectMusicBuffer>))] IDirectMusicBuffer pBuffer);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetReadNotificationHandle(HANDLE hEvent);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Read([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirectMusicBuffer>))] IDirectMusicBuffer pBuffer);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DownloadInstrument([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirectMusicInstrument>))] IDirectMusicInstrument pInstrument, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirectMusicDownloadedInstrument>))] out IDirectMusicDownloadedInstrument ppDownloadedInstrument, ref DMUS_NOTERANGE pNoteRanges, uint dwNumNoteRanges);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnloadInstrument([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirectMusicDownloadedInstrument>))] IDirectMusicDownloadedInstrument pDownloadedInstrument);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLatencyClock([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IReferenceClock>))] out IReferenceClock ppClock);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRunningStats(ref DMUS_SYNTHSTATS pStats);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Compact();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCaps(ref DMUS_PORTCAPS pPortCaps);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DeviceIoControl(uint dwIoControlCode, nint lpInBuffer, uint nInBufferSize, nint lpOutBuffer, uint nOutBufferSize, ref uint lpBytesReturned, ref OVERLAPPED lpOverlapped);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetNumChannelGroups(uint dwChannelGroups);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNumChannelGroups(ref uint pdwChannelGroups);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Activate(BOOL fActive);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetChannelPriority(uint dwChannelGroup, uint dwChannel, uint dwPriority);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetChannelPriority(uint dwChannelGroup, uint dwChannel, ref uint pdwPriority);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDirectSound([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirectSound>))] IDirectSound pDirectSound, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirectSoundBuffer>))] IDirectSoundBuffer pDirectSoundBuffer);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFormat(ref WAVEFORMATEX pWaveFormatEx, ref uint pdwWaveFormatExSize, ref uint pdwBufferSize);
}
