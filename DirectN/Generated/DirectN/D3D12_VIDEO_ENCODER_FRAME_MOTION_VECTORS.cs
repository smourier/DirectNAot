#nullable enable
namespace DirectN;

public partial struct D3D12_VIDEO_ENCODER_FRAME_MOTION_VECTORS
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public nint pOpaqueLayoutBuffer;
        
        [FieldOffset(0)]
        public nint pCPUBuffer;
    }
    
    public D3D12_VIDEO_ENCODER_INPUT_MAP_SOURCE MapSource;
    public _Anonymous_e__Union Anonymous;
}
