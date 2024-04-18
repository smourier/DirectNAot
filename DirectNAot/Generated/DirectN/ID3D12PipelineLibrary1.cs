namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/nn-d3d12-id3d12pipelinelibrary1
[GeneratedComInterface, Guid("80eabf42-2568-4e5e-bd82-c37f86961dc3")]
public partial interface ID3D12PipelineLibrary1 : ID3D12PipelineLibrary
{
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12pipelinelibrary1-loadpipeline
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT LoadPipeline(PWSTR pName, in D3D12_PIPELINE_STATE_STREAM_DESC pDesc, in Guid riid, out nint ppPipelineState);
}
