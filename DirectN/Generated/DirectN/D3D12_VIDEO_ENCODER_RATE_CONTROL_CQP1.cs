#nullable enable
namespace DirectN;

public partial struct D3D12_VIDEO_ENCODER_RATE_CONTROL_CQP1
{
    public uint ConstantQP_FullIntracodedFrame;
    public uint ConstantQP_InterPredictedFrame_PrevRefOnly;
    public uint ConstantQP_InterPredictedFrame_BiDirectionalRef;
    public uint QualityVsSpeed;
}
