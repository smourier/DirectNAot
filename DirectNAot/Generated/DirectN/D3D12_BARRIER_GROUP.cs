#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_barrier_group
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_BARRIER_GROUP
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public nint pGlobalBarriers;
        
        [FieldOffset(0)]
        public nint pTextureBarriers;
        
        [FieldOffset(0)]
        public nint pBufferBarriers;
    }
    
    public D3D12_BARRIER_TYPE Type;
    public uint NumBarriers;
    public _Anonymous_e__Union Anonymous;
}
