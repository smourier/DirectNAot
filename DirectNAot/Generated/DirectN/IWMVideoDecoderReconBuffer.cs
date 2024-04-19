namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nn-wmcodecdsp-iwmvideodecoderreconbuffer
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("45bda2ac-88e2-4923-98ba-3949080711a3")]
public partial interface IWMVideoDecoderReconBuffer
{
    // https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nf-wmcodecdsp-iwmvideodecoderreconbuffer-getreconstructedvideoframesize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetReconstructedVideoFrameSize(ref uint pdwSize);
    
    // https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nf-wmcodecdsp-iwmvideodecoderreconbuffer-getreconstructedvideoframe
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetReconstructedVideoFrame(IMediaBuffer pBuf);
    
    // https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nf-wmcodecdsp-iwmvideodecoderreconbuffer-setreconstructedvideoframe
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetReconstructedVideoFrame(IMediaBuffer pBuf);
}
