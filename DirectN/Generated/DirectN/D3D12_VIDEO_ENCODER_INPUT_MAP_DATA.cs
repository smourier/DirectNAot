#nullable enable
namespace DirectN;

public partial struct D3D12_VIDEO_ENCODER_INPUT_MAP_DATA
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public D3D12_VIDEO_ENCODER_INPUT_MAP_DATA_QUANTIZATION_MATRIX Quantization;
        
        [FieldOffset(0)]
        public D3D12_VIDEO_ENCODER_INPUT_MAP_DATA_DIRTY_REGIONS DirtyRegions;
        
        [FieldOffset(0)]
        public D3D12_VIDEO_ENCODER_INPUT_MAP_DATA_MOTION_VECTORS MotionVectors;
    }
    
    public D3D12_VIDEO_ENCODER_INPUT_MAP_TYPE MapType;
    public _Anonymous_e__Union Anonymous;
}
