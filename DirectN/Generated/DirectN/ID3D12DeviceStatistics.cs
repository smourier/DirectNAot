#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("3d5ca1a8-a39e-4619-95e0-f9b0a40340f5")]
public partial interface ID3D12DeviceStatistics
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStateObjectStatistics(out D3D12_STATE_OBJECT_STATISTICS pStatistics);
}
