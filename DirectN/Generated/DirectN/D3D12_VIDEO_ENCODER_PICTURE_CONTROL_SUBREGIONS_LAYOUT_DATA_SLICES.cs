#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_video_encoder_picture_control_subregions_layout_data_slices
public partial struct D3D12_VIDEO_ENCODER_PICTURE_CONTROL_SUBREGIONS_LAYOUT_DATA_SLICES
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public uint MaxBytesPerSlice;
        
        [FieldOffset(0)]
        public uint NumberOfCodingUnitsPerSlice;
        
        [FieldOffset(0)]
        public uint NumberOfRowsPerSlice;
        
        [FieldOffset(0)]
        public uint NumberOfSlicesPerFrame;
    }
    
    public _Anonymous_e__Union Anonymous;
}
