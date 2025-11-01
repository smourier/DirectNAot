#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_raytracing_acceleration_structure_postbuild_info_serialization_desc
public partial struct D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_SERIALIZATION_DESC
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public ulong NumBottomLevelAccelerationStructurePointers;
        
        [FieldOffset(0)]
        public ulong NumBottomLevelAccelerationStructureHeaderAndPointerListPairs;
    }
    
    public ulong SerializedSizeInBytes;
    public _Anonymous_e__Union Anonymous;
}
