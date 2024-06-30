#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_resource_barrier
public partial struct D3D12_RESOURCE_BARRIER
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public D3D12_RESOURCE_TRANSITION_BARRIER Transition;
        
        [FieldOffset(0)]
        public D3D12_RESOURCE_ALIASING_BARRIER Aliasing;
        
        [FieldOffset(0)]
        public D3D12_RESOURCE_UAV_BARRIER UAV;
    }
    
    public D3D12_RESOURCE_BARRIER_TYPE Type;
    public D3D12_RESOURCE_BARRIER_FLAGS Flags;
    public _Anonymous_e__Union Anonymous;
}
