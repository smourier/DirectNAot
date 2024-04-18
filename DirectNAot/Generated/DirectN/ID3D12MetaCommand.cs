namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/nn-d3d12-id3d12metacommand
[GeneratedComInterface, Guid("dbb84c27-36ce-4fc9-b801-f048c46ac570")]
public partial interface ID3D12MetaCommand : ID3D12Pageable
{
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12metacommand-getrequiredparameterresourcesize
    [PreserveSig]
    public ulong GetRequiredParameterResourceSize(D3D12_META_COMMAND_PARAMETER_STAGE Stage, uint ParameterIndex);
}
