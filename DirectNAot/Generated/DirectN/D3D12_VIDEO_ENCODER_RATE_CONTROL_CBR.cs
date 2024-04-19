namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_video_encoder_rate_control_cbr
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_VIDEO_ENCODER_RATE_CONTROL_CBR
{
    public uint InitialQP;
    public uint MinQP;
    public uint MaxQP;
    public ulong MaxFrameBitSize;
    public ulong TargetBitRate;
    public ulong VBVCapacity;
    public ulong InitialVBVFullness;
}
