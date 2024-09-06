#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/control/nn-control-ibasicvideo
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("56a868b5-0ad4-11ce-b03a-0020af0ba770")]
public partial interface IBasicVideo : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-ibasicvideo-get_avgtimeperframe
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_AvgTimePerFrame(out double pAvgTimePerFrame);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-ibasicvideo-get_bitrate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_BitRate(out int pBitRate);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-ibasicvideo-get_biterrorrate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_BitErrorRate(out int pBitErrorRate);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-ibasicvideo-get_videowidth
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_VideoWidth(out int pVideoWidth);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-ibasicvideo-get_videoheight
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_VideoHeight(out int pVideoHeight);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-ibasicvideo-put_sourceleft
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_SourceLeft(int SourceLeft);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-ibasicvideo-get_sourceleft
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_SourceLeft(out int pSourceLeft);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-ibasicvideo-put_sourcewidth
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_SourceWidth(int SourceWidth);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-ibasicvideo-get_sourcewidth
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_SourceWidth(out int pSourceWidth);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-ibasicvideo-put_sourcetop
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_SourceTop(int SourceTop);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-ibasicvideo-get_sourcetop
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_SourceTop(out int pSourceTop);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-ibasicvideo-put_sourceheight
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_SourceHeight(int SourceHeight);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-ibasicvideo-get_sourceheight
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_SourceHeight(out int pSourceHeight);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-ibasicvideo-put_destinationleft
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_DestinationLeft(int DestinationLeft);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-ibasicvideo-get_destinationleft
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_DestinationLeft(out int pDestinationLeft);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-ibasicvideo-put_destinationwidth
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_DestinationWidth(int DestinationWidth);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-ibasicvideo-get_destinationwidth
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_DestinationWidth(out int pDestinationWidth);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-ibasicvideo-put_destinationtop
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_DestinationTop(int DestinationTop);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-ibasicvideo-get_destinationtop
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_DestinationTop(out int pDestinationTop);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-ibasicvideo-put_destinationheight
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_DestinationHeight(int DestinationHeight);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-ibasicvideo-get_destinationheight
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_DestinationHeight(out int pDestinationHeight);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-ibasicvideo-setsourceposition
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSourcePosition(int Left, int Top, int Width, int Height);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-ibasicvideo-getsourceposition
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSourcePosition(out int pLeft, out int pTop, out int pWidth, out int pHeight);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-ibasicvideo-setdefaultsourceposition
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDefaultSourcePosition();
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-ibasicvideo-setdestinationposition
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDestinationPosition(int Left, int Top, int Width, int Height);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-ibasicvideo-getdestinationposition
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDestinationPosition(out int pLeft, out int pTop, out int pWidth, out int pHeight);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-ibasicvideo-setdefaultdestinationposition
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDefaultDestinationPosition();
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-ibasicvideo-getvideosize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVideoSize(out int pWidth, out int pHeight);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-ibasicvideo-getvideopaletteentries
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVideoPaletteEntries(int StartIndex, int Entries, out int pRetrieved, out int pPalette);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-ibasicvideo-getcurrentimage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrentImage(ref int pBufferSize, out int pDIBImage);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-ibasicvideo-isusingdefaultsource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsUsingDefaultSource();
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-ibasicvideo-isusingdefaultdestination
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsUsingDefaultDestination();
}
