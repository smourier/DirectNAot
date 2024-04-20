namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfmediaengine/nn-mfmediaengine-imfmediaengineex
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("83015ead-b1e6-40d0-a98a-37145ffe1ad1")]
public partial interface IMFMediaEngineEx : IMFMediaEngine
{
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengineex-setsourcefrombytestream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSourceFromByteStream(IMFByteStream pByteStream, BSTR pURL);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengineex-getstatistics
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStatistics(MF_MEDIA_ENGINE_STATISTIC StatisticID, out PROPVARIANT pStatistic);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengineex-updatevideostream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UpdateVideoStream(nint /* optional MFVideoNormalizedRect */ pSrc, nint /* optional FoundationRECT */ pDst, nint /* optional MFARGB */ pBorderClr);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengineex-getbalance
    [PreserveSig]
    double GetBalance();
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengineex-setbalance
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBalance(double balance);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengineex-isplaybackratesupported
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    bool IsPlaybackRateSupported(double rate);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengineex-framestep
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FrameStep([MarshalAs(UnmanagedType.U4)] bool Forward);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengineex-getresourcecharacteristics
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetResourceCharacteristics(out uint pCharacteristics);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengineex-getpresentationattribute
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPresentationAttribute(in Guid guidMFAttribute, out PROPVARIANT pvValue);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengineex-getnumberofstreams
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNumberOfStreams(out uint pdwStreamCount);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengineex-getstreamattribute
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStreamAttribute(uint dwStreamIndex, in Guid guidMFAttribute, out PROPVARIANT pvValue);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengineex-getstreamselection
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStreamSelection(uint dwStreamIndex, [MarshalAs(UnmanagedType.U4)] out bool pEnabled);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengineex-setstreamselection
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetStreamSelection(uint dwStreamIndex, [MarshalAs(UnmanagedType.U4)] bool Enabled);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengineex-applystreamselections
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ApplyStreamSelections();
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengineex-isprotected
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsProtected([MarshalAs(UnmanagedType.U4)] out bool pProtected);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengineex-insertvideoeffect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InsertVideoEffect(nint pEffect, [MarshalAs(UnmanagedType.U4)] bool fOptional);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengineex-insertaudioeffect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InsertAudioEffect(nint pEffect, [MarshalAs(UnmanagedType.U4)] bool fOptional);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengineex-removealleffects
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveAllEffects();
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengineex-settimelinemarkertimer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTimelineMarkerTimer(double timeToFire);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengineex-gettimelinemarkertimer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTimelineMarkerTimer(out double pTimeToFire);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengineex-canceltimelinemarkertimer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CancelTimelineMarkerTimer();
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengineex-isstereo3d
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    bool IsStereo3D();
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengineex-getstereo3dframepackingmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStereo3DFramePackingMode(out MF_MEDIA_ENGINE_S3D_PACKING_MODE packMode);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengineex-setstereo3dframepackingmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetStereo3DFramePackingMode(MF_MEDIA_ENGINE_S3D_PACKING_MODE packMode);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengineex-getstereo3drendermode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStereo3DRenderMode(out MF3DVideoOutputType outputType);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengineex-setstereo3drendermode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetStereo3DRenderMode(MF3DVideoOutputType outputType);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengineex-enablewindowlessswapchainmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnableWindowlessSwapchainMode([MarshalAs(UnmanagedType.U4)] bool fEnable);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengineex-getvideoswapchainhandle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVideoSwapchainHandle(out HANDLE phSwapchain);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengineex-enablehorizontalmirrormode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnableHorizontalMirrorMode([MarshalAs(UnmanagedType.U4)] bool fEnable);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengineex-getaudiostreamcategory
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAudioStreamCategory(out uint pCategory);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengineex-setaudiostreamcategory
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAudioStreamCategory(uint category);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengineex-getaudioendpointrole
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAudioEndpointRole(out uint pRole);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengineex-setaudioendpointrole
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAudioEndpointRole(uint role);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengineex-getrealtimemode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRealTimeMode([MarshalAs(UnmanagedType.U4)] out bool pfEnabled);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengineex-setrealtimemode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRealTimeMode([MarshalAs(UnmanagedType.U4)] bool fEnable);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengineex-setcurrenttimeex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCurrentTimeEx(double seekTime, MF_MEDIA_ENGINE_SEEK_MODE seekMode);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengineex-enabletimeupdatetimer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnableTimeUpdateTimer([MarshalAs(UnmanagedType.U4)] bool fEnableTimer);
}
