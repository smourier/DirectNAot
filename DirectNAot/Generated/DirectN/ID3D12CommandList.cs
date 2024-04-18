namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/nn-d3d12-id3d12commandlist
[GeneratedComInterface, Guid("7116d91c-e7e4-47ce-b8c6-ec8168f437e5")]
public partial interface ID3D12CommandList : ID3D12DeviceChild
{
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12commandlist-gettype
    [PreserveSig]
    public D3D12_COMMAND_LIST_TYPE GetType();
}
