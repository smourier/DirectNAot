#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("8f1359db-d8d1-42f9-b5cf-79f4cbad0d3d")]
public partial interface ID3D12PageableTools
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAllocation(ref D3D12_GPU_VIRTUAL_ADDRESS_RANGE pAllocation);
}
