namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_video_processor_output_view_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D11_VIDEO_PROCESSOR_OUTPUT_VIEW_DESC
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public D3D11_TEX2D_VPOV Texture2D;
        
        [FieldOffset(0)]
        public D3D11_TEX2D_ARRAY_VPOV Texture2DArray;
    }
    
    public D3D11_VPOV_DIMENSION ViewDimension;
    public _Anonymous_e__Union Anonymous;
}
