#nullable enable
namespace DirectN;

public partial struct D3D12_SERIALIZED_RAYTRACING_ACCELERATION_STRUCTURE_HEADER1
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public uint NumBottomLevelAccelerationStructurePointersAfterHeader;
        
        [FieldOffset(0)]
        public uint NumBlocks;
    }
    
    public D3D12_SERIALIZED_DATA_DRIVER_MATCHING_IDENTIFIER DriverMatchingIdentifier;
    public ulong SerializedSizeInBytesIncludingHeader;
    public ulong DeserializedSizeInBytes;
    public _Anonymous_e__Union Anonymous;
    public D3D12_SERIALIZED_RAYTRACING_ACCELERATION_STRUCTURE_HEADER_POSTAMBLE_TYPE HeaderPostambleType;
}
