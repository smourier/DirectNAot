#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("065acf71-f863-4b89-82f4-02e4d5886757")]
public partial interface ID3D12WorkGraphProperties
{
    [PreserveSig]
    uint GetNumWorkGraphs();
    
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    PWSTR GetProgramName(uint WorkGraphIndex);
    
    [PreserveSig]
    uint GetWorkGraphIndex(PWSTR pProgramName);
    
    [PreserveSig]
    uint GetNumNodes(uint WorkGraphIndex);
    
    [PreserveSig]
    D3D12_NODE_ID GetNodeID(uint WorkGraphIndex, uint NodeIndex);
    
    [PreserveSig]
    uint GetNodeIndex(uint WorkGraphIndex, D3D12_NODE_ID NodeID);
    
    [PreserveSig]
    uint GetNodeLocalRootArgumentsTableIndex(uint WorkGraphIndex, uint NodeIndex);
    
    [PreserveSig]
    uint GetNumEntrypoints(uint WorkGraphIndex);
    
    [PreserveSig]
    D3D12_NODE_ID GetEntrypointID(uint WorkGraphIndex, uint EntrypointIndex);
    
    [PreserveSig]
    uint GetEntrypointIndex(uint WorkGraphIndex, D3D12_NODE_ID NodeID);
    
    [PreserveSig]
    uint GetEntrypointRecordSizeInBytes(uint WorkGraphIndex, uint EntrypointIndex);
    
    [PreserveSig]
    void GetWorkGraphMemoryRequirements(uint WorkGraphIndex, out D3D12_WORK_GRAPH_MEMORY_REQUIREMENTS pWorkGraphMemoryRequirements);
    
    [PreserveSig]
    uint GetEntrypointRecordAlignmentInBytes(uint WorkGraphIndex, uint EntrypointIndex);
}
