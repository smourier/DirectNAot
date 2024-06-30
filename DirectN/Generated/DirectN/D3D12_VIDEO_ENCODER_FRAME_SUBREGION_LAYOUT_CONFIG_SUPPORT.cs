#nullable enable
namespace DirectN;

public partial struct D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_CONFIG_SUPPORT
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public nint pAV1Support;
    }
    
    public uint DataSize;
    public _Anonymous_e__Union Anonymous;
}
