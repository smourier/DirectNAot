#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxvahd/nn-dxvahd-idxvahd_videoprocessor
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("95f4edf4-6e03-4cd7-be1b-3075d665aa52")]
public partial interface IDXVAHD_VideoProcessor
{
    // https://learn.microsoft.com/windows/win32/api/dxvahd/nf-dxvahd-idxvahd_videoprocessor-setvideoprocessbltstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetVideoProcessBltState(DXVAHD_BLT_STATE State, uint DataSize, nint pData);
    
    // https://learn.microsoft.com/windows/win32/api/dxvahd/nf-dxvahd-idxvahd_videoprocessor-getvideoprocessbltstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVideoProcessBltState(DXVAHD_BLT_STATE State, uint DataSize, nint pData);
    
    // https://learn.microsoft.com/windows/win32/api/dxvahd/nf-dxvahd-idxvahd_videoprocessor-setvideoprocessstreamstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetVideoProcessStreamState(uint StreamNumber, DXVAHD_STREAM_STATE State, uint DataSize, nint pData);
    
    // https://learn.microsoft.com/windows/win32/api/dxvahd/nf-dxvahd-idxvahd_videoprocessor-getvideoprocessstreamstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVideoProcessStreamState(uint StreamNumber, DXVAHD_STREAM_STATE State, uint DataSize, nint pData);
    
    // https://learn.microsoft.com/windows/win32/api/dxvahd/nf-dxvahd-idxvahd_videoprocessor-videoprocessblthd
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT VideoProcessBltHD(IDirect3DSurface9 pOutputSurface, uint OutputFrame, uint StreamCount, [In][MarshalUsing(CountElementName = nameof(StreamCount))] DXVAHD_STREAM_DATA[] pStreams);
}
