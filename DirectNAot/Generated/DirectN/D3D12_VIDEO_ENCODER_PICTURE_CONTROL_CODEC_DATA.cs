#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_video_encoder_picture_control_codec_data
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public nint pH264PicData;
        
        [FieldOffset(0)]
        public nint pHEVCPicData;
        
        [FieldOffset(0)]
        public nint pHEVCPicData1;
        
        [FieldOffset(0)]
        public nint pAV1PicData;
    }
    
    public uint DataSize;
    public _Anonymous_e__Union Anonymous;
}
