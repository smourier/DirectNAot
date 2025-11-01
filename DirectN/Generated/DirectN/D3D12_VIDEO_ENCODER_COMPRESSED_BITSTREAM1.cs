#nullable enable
namespace DirectN;

public partial struct D3D12_VIDEO_ENCODER_COMPRESSED_BITSTREAM1
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public D3D12_VIDEO_ENCODER_COMPRESSED_BITSTREAM FrameOutputBuffer;
        
        [FieldOffset(0)]
        public D3D12_VIDEO_ENCODER_SUBREGION_COMPRESSED_BITSTREAM SubregionOutputBuffers;
    }
    
    public D3D12_VIDEO_ENCODER_COMPRESSED_BITSTREAM_NOTIFICATION_MODE NotificationMode;
    public _Anonymous_e__Union Anonymous;
}
