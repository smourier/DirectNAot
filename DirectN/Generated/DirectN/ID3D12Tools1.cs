#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("e4fbc019-dd3c-43e1-8f32-7f649575f0a0")]
public partial interface ID3D12Tools1 : ID3D12Tools
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReserveGPUVARangesAtCreate([In][MarshalUsing(CountElementName = nameof(uiNumRanges))] D3D12_GPU_VIRTUAL_ADDRESS_RANGE[] pRanges, uint uiNumRanges);
    
    [PreserveSig]
    void ClearReservedGPUVARangesList();
}
