namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/nn-d3d12video-id3d12videoprocesscommandlist1
[GeneratedComInterface, Guid("542c5c4d-7596-434f-8c93-4efa6766f267")]
public partial interface ID3D12VideoProcessCommandList1 : ID3D12VideoProcessCommandList
{
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videoprocesscommandlist1-processframes1
    [PreserveSig]
    void ProcessFrames1(ID3D12VideoProcessor pVideoProcessor, in D3D12_VIDEO_PROCESS_OUTPUT_STREAM_ARGUMENTS pOutputArguments, uint NumInputStreams, in D3D12_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS1 pInputArguments);
}
