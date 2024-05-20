#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/nn-d3d12sdklayers-id3d12debugcommandlist1
[GeneratedComInterface, Guid("102ca951-311b-4b01-b11f-ecb83e061b37")]
public partial interface ID3D12DebugCommandList1
{
    // https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/nf-d3d12sdklayers-id3d12debugcommandlist1-assertresourcestate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    bool AssertResourceState(ID3D12Resource pResource, uint Subresource, uint State);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/nf-d3d12sdklayers-id3d12debugcommandlist1-setdebugparameter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDebugParameter(D3D12_DEBUG_COMMAND_LIST_PARAMETER_TYPE Type, nint pData, uint DataSize);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/nf-d3d12sdklayers-id3d12debugcommandlist1-getdebugparameter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDebugParameter(D3D12_DEBUG_COMMAND_LIST_PARAMETER_TYPE Type, nint pData, uint DataSize);
}
