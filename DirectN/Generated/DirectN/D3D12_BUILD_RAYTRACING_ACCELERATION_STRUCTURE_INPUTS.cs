#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_build_raytracing_acceleration_structure_inputs
public partial struct D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_INPUTS
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public ulong InstanceDescs;
        
        [FieldOffset(0)]
        public nint pGeometryDescs;
        
        [FieldOffset(0)]
        public nint ppGeometryDescs;
    }
    
    public D3D12_RAYTRACING_ACCELERATION_STRUCTURE_TYPE Type;
    public D3D12_RAYTRACING_ACCELERATION_STRUCTURE_BUILD_FLAGS Flags;
    public uint NumDescs;
    public D3D12_ELEMENTS_LAYOUT DescsLayout;
    public _Anonymous_e__Union Anonymous;
}
