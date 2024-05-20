#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/nn-d3d12-id3d12graphicscommandlist4
[GeneratedComInterface, Guid("8754318e-d3a9-4541-98cf-645b50dc4874")]
public partial interface ID3D12GraphicsCommandList4 : ID3D12GraphicsCommandList3
{
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist4-beginrenderpass
    [PreserveSig]
    void BeginRenderPass(uint NumRenderTargets, nint /* optional D3D12_RENDER_PASS_RENDER_TARGET_DESC* */ pRenderTargets, nint /* optional D3D12_RENDER_PASS_DEPTH_STENCIL_DESC* */ pDepthStencil, D3D12_RENDER_PASS_FLAGS Flags);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist4-endrenderpass
    [PreserveSig]
    void EndRenderPass();
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist4-initializemetacommand
    [PreserveSig]
    void InitializeMetaCommand(ID3D12MetaCommand pMetaCommand, nint /* optional void* */ pInitializationParametersData, nuint InitializationParametersDataSizeInBytes);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist4-executemetacommand
    [PreserveSig]
    void ExecuteMetaCommand(ID3D12MetaCommand pMetaCommand, nint /* optional void* */ pExecutionParametersData, nuint ExecutionParametersDataSizeInBytes);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist4-buildraytracingaccelerationstructure
    [PreserveSig]
    void BuildRaytracingAccelerationStructure(in D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_DESC pDesc, uint NumPostbuildInfoDescs, nint /* optional D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_DESC* */ pPostbuildInfoDescs);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist4-emitraytracingaccelerationstructurepostbuildinfo
    [PreserveSig]
    void EmitRaytracingAccelerationStructurePostbuildInfo(in D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_DESC pDesc, uint NumSourceAccelerationStructures, [In][MarshalUsing(CountElementName = nameof(NumSourceAccelerationStructures))] ulong[] pSourceAccelerationStructureData);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist4-copyraytracingaccelerationstructure
    [PreserveSig]
    void CopyRaytracingAccelerationStructure(ulong DestAccelerationStructureData, ulong SourceAccelerationStructureData, D3D12_RAYTRACING_ACCELERATION_STRUCTURE_COPY_MODE Mode);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist4-setpipelinestate1
    [PreserveSig]
    void SetPipelineState1(ID3D12StateObject pStateObject);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist4-dispatchrays
    [PreserveSig]
    void DispatchRays(in D3D12_DISPATCH_RAYS_DESC pDesc);
}
