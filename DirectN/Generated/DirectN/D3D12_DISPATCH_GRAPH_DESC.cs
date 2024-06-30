#nullable enable
namespace DirectN;

public partial struct D3D12_DISPATCH_GRAPH_DESC
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public D3D12_NODE_CPU_INPUT NodeCPUInput;
        
        [FieldOffset(0)]
        public ulong NodeGPUInput;
        
        [FieldOffset(0)]
        public D3D12_MULTI_NODE_CPU_INPUT MultiNodeCPUInput;
        
        [FieldOffset(0)]
        public ulong MultiNodeGPUInput;
    }
    
    public D3D12_DISPATCH_MODE Mode;
    public _Anonymous_e__Union Anonymous;
}
