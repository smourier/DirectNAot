namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/presentation/nn-presentation-ipresentationmanager
[GeneratedComInterface, Guid("fb562f82-6292-470a-88b1-843661e7f20c")]
public partial interface IPresentationManager
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT AddBufferFromResource(nint resource, out IPresentationBuffer presentationBuffer);
    
    // https://learn.microsoft.com/windows/win32/api/presentation/nf-presentation-ipresentationmanager-createpresentationsurface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreatePresentationSurface(HANDLE compositionSurfaceHandle, out IPresentationSurface presentationSurface);
    
    // https://learn.microsoft.com/windows/win32/api/presentation/nf-presentation-ipresentationmanager-getnextpresentid
    [PreserveSig]
    public ulong GetNextPresentId();
    
    // https://learn.microsoft.com/windows/win32/api/presentation/nf-presentation-ipresentationmanager-settargettime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetTargetTime(SystemInterruptTime targetTime);
    
    // https://learn.microsoft.com/windows/win32/api/presentation/nf-presentation-ipresentationmanager-setpreferredpresentduration
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetPreferredPresentDuration(SystemInterruptTime preferredDuration, SystemInterruptTime deviationTolerance);
    
    // https://learn.microsoft.com/windows/win32/api/presentation/nf-presentation-ipresentationmanager-forcevsyncinterrupt
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT ForceVSyncInterrupt(byte forceVsyncInterrupt);
    
    // https://learn.microsoft.com/windows/win32/api/presentation/nf-presentation-ipresentationmanager-present
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Present();
    
    // https://learn.microsoft.com/windows/win32/api/presentation/nf-presentation-ipresentationmanager-getpresentretiringfence
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetPresentRetiringFence(in Guid riid, out nint fence);
    
    // https://learn.microsoft.com/windows/win32/api/presentation/nf-presentation-ipresentationmanager-cancelpresentsfrom
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CancelPresentsFrom(ulong presentIdToCancelFrom);
    
    // https://learn.microsoft.com/windows/win32/api/presentation/nf-presentation-ipresentationmanager-getlostevent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetLostEvent(out HANDLE lostEventHandle);
    
    // https://learn.microsoft.com/windows/win32/api/presentation/nf-presentation-ipresentationmanager-getpresentstatisticsavailableevent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetPresentStatisticsAvailableEvent(out HANDLE presentStatisticsAvailableEventHandle);
    
    // https://learn.microsoft.com/windows/win32/api/presentation/nf-presentation-ipresentationmanager-enablepresentstatisticskind
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT EnablePresentStatisticsKind(PresentStatisticsKind presentStatisticsKind, byte enabled);
    
    // https://learn.microsoft.com/windows/win32/api/presentation/nf-presentation-ipresentationmanager-getnextpresentstatistics
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetNextPresentStatistics(out IPresentStatistics nextPresentStatistics);
}
