namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_video_encoder_level_setting
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_VIDEO_ENCODER_LEVEL_SETTING
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public nint pH264LevelSetting;
        
        [FieldOffset(0)]
        public nint pHEVCLevelSetting;
        
        [FieldOffset(0)]
        public nint pAV1LevelSetting;
    }
    
    public uint DataSize;
    public _Anonymous_e__Union Anonymous;
}
