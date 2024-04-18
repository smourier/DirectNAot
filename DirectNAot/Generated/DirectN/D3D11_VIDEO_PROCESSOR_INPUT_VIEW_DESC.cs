namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_video_processor_input_view_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D11_VIDEO_PROCESSOR_INPUT_VIEW_DESC
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public D3D11_TEX2D_VPIV Texture2D;
    }
    
    public uint FourCC;
    public D3D11_VPIV_DIMENSION ViewDimension;
    public _Anonymous_e__Union Anonymous;
}
