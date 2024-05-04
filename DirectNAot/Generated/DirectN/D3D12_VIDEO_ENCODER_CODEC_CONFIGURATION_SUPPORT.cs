#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_video_encoder_codec_configuration_support
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public nint pH264Support;
        
        [FieldOffset(0)]
        public nint pHEVCSupport;
        
        [FieldOffset(0)]
        public nint pAV1Support;
    }
    
    public uint DataSize;
    public _Anonymous_e__Union Anonymous;
}
