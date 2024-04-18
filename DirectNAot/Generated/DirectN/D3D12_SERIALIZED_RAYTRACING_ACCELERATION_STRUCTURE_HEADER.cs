namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_serialized_raytracing_acceleration_structure_header
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_SERIALIZED_RAYTRACING_ACCELERATION_STRUCTURE_HEADER
{
    public D3D12_SERIALIZED_DATA_DRIVER_MATCHING_IDENTIFIER DriverMatchingIdentifier;
    public ulong SerializedSizeInBytesIncludingHeader;
    public ulong DeserializedSizeInBytes;
    public ulong NumBottomLevelAccelerationStructurePointersAfterHeader;
}
