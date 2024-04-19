namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_video_encoder_sequence_gop_structure
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_VIDEO_ENCODER_SEQUENCE_GOP_STRUCTURE
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public nint pH264GroupOfPictures;
        
        [FieldOffset(0)]
        public nint pHEVCGroupOfPictures;
        
        [FieldOffset(0)]
        public nint pAV1SequenceStructure;
    }
    
    public uint DataSize;
    public _Anonymous_e__Union Anonymous;
}
