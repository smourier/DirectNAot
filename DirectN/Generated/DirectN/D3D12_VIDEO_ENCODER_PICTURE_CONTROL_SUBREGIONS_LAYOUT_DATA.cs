#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_video_encoder_picture_control_subregions_layout_data
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_VIDEO_ENCODER_PICTURE_CONTROL_SUBREGIONS_LAYOUT_DATA
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public nint pSlicesPartition_H264;
        
        [FieldOffset(0)]
        public nint pSlicesPartition_HEVC;
        
        [FieldOffset(0)]
        public nint pTilesPartition_AV1;
    }
    
    public uint DataSize;
    public _Anonymous_e__Union Anonymous;
}
