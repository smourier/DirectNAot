#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_video_decoder_output_view_desc
public partial struct D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public D3D11_TEX2D_VDOV Texture2D;
    }
    
    public Guid DecodeProfile;
    public D3D11_VDOV_DIMENSION ViewDimension;
    public _Anonymous_e__Union Anonymous;
}
