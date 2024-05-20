#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_video_encoder_profile_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_VIDEO_ENCODER_PROFILE_DESC
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public nint pH264Profile;
        
        [FieldOffset(0)]
        public nint pHEVCProfile;
        
        [FieldOffset(0)]
        public nint pAV1Profile;
    }
    
    public uint DataSize;
    public _Anonymous_e__Union Anonymous;
}
