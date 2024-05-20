#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_SET_PROGRAM_DESC
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public D3D12_SET_GENERIC_PIPELINE_DESC GenericPipeline;
        
        [FieldOffset(0)]
        public D3D12_SET_RAYTRACING_PIPELINE_DESC RaytracingPipeline;
        
        [FieldOffset(0)]
        public D3D12_SET_WORK_GRAPH_DESC WorkGraph;
    }
    
    public D3D12_PROGRAM_TYPE Type;
    public _Anonymous_e__Union Anonymous;
}
