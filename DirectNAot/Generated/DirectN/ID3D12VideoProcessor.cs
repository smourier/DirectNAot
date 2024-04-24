namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/nn-d3d12video-id3d12videoprocessor
[GeneratedComInterface, Guid("304fdb32-bede-410a-8545-943ac6a46138")]
public partial interface ID3D12VideoProcessor : ID3D12Pageable
{
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videoprocessor-getnodemask
    [PreserveSig]
    uint GetNodeMask();
    
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videoprocessor-getnuminputstreamdescs
    [PreserveSig]
    uint GetNumInputStreamDescs();
    
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videoprocessor-getinputstreamdescs
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetInputStreamDescs(uint NumInputStreamDescs, [MarshalUsing(CountElementName = nameof(NumInputStreamDescs))] out D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC[] pInputStreamDescs);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videoprocessor-getoutputstreamdesc
    [PreserveSig]
    D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC GetOutputStreamDesc();
}
