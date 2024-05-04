#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_serialized_data_driver_matching_identifier
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_SERIALIZED_DATA_DRIVER_MATCHING_IDENTIFIER
{
    public Guid DriverOpaqueGUID;
    public InlineArrayByte16 DriverOpaqueVersioningData;
}
