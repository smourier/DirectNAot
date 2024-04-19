namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_video_encoder_rate_control_cqp
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_VIDEO_ENCODER_RATE_CONTROL_CQP
{
    public uint ConstantQP_FullIntracodedFrame;
    public uint ConstantQP_InterPredictedFrame_PrevRefOnly;
    public uint ConstantQP_InterPredictedFrame_BiDirectionalRef;
}
