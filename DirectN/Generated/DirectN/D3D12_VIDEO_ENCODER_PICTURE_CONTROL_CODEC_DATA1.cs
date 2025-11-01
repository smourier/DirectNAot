#nullable enable
namespace DirectN;

public partial struct D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA1
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public nint pH264PicData;
        
        [FieldOffset(0)]
        public nint pHEVCPicData;
        
        [FieldOffset(0)]
        public nint pAV1PicData;
    }
    
    public uint DataSize;
    public _Anonymous_e__Union Anonymous;
}
