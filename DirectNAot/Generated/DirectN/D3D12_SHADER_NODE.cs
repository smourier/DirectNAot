#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_SHADER_NODE
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public nint pBroadcastingLaunchOverrides;
        
        [FieldOffset(0)]
        public nint pCoalescingLaunchOverrides;
        
        [FieldOffset(0)]
        public nint pThreadLaunchOverrides;
        
        [FieldOffset(0)]
        public nint pCommonComputeNodeOverrides;
    }
    
    public PWSTR Shader;
    public D3D12_NODE_OVERRIDES_TYPE OverridesType;
    public _Anonymous_e__Union Anonymous;
}
