#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/nn-d3d12-id3d12stateobjectproperties
[GeneratedComInterface, Guid("de5fa827-9bf9-4f26-89ff-d7f56fde3860")]
public partial interface ID3D12StateObjectProperties
{
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12stateobjectproperties-getshaderidentifier
    [PreserveSig]
    nint GetShaderIdentifier(PWSTR pExportName);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12stateobjectproperties-getshaderstacksize
    [PreserveSig]
    ulong GetShaderStackSize(PWSTR pExportName);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12stateobjectproperties-getpipelinestacksize
    [PreserveSig]
    ulong GetPipelineStackSize();
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12stateobjectproperties-setpipelinestacksize
    [PreserveSig]
    void SetPipelineStackSize(ulong PipelineStackSizeInBytes);
}
