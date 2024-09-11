#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/nn-d3d12-id3d12pipelinelibrary
[GeneratedComInterface, Guid("c64226a8-9201-46af-b4cc-53fb9ff7414f")]
public partial interface ID3D12PipelineLibrary : ID3D12DeviceChild
{
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12pipelinelibrary-storepipeline
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StorePipeline(PWSTR pName, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12PipelineState>))] ID3D12PipelineState pPipeline);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12pipelinelibrary-loadgraphicspipeline
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LoadGraphicsPipeline(PWSTR pName, in D3D12_GRAPHICS_PIPELINE_STATE_DESC pDesc, in Guid riid, out nint /* void */ ppPipelineState);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12pipelinelibrary-loadcomputepipeline
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LoadComputePipeline(PWSTR pName, in D3D12_COMPUTE_PIPELINE_STATE_DESC pDesc, in Guid riid, out nint /* void */ ppPipelineState);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12pipelinelibrary-getserializedsize
    [PreserveSig]
    nuint GetSerializedSize();
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12pipelinelibrary-serialize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Serialize(nint pData, nuint DataSizeInBytes);
}
