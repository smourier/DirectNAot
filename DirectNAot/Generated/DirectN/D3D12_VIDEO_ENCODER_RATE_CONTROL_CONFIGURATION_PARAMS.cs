namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_video_encoder_rate_control_configuration_params
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_VIDEO_ENCODER_RATE_CONTROL_CONFIGURATION_PARAMS
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public nint pConfiguration_CQP;
        
        [FieldOffset(0)]
        public nint pConfiguration_CBR;
        
        [FieldOffset(0)]
        public nint pConfiguration_VBR;
        
        [FieldOffset(0)]
        public nint pConfiguration_QVBR;
        
        [FieldOffset(0)]
        public nint pConfiguration_CQP1;
        
        [FieldOffset(0)]
        public nint pConfiguration_CBR1;
        
        [FieldOffset(0)]
        public nint pConfiguration_VBR1;
        
        [FieldOffset(0)]
        public nint pConfiguration_QVBR1;
        
        [FieldOffset(0)]
        public nint pConfiguration_AbsoluteQPMap;
    }
    
    public uint DataSize;
    public _Anonymous_e__Union Anonymous;
}
