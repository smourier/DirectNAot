#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_video_color
public partial struct D3D11_VIDEO_COLOR
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public D3D11_VIDEO_COLOR_YCbCrA YCbCr;
        
        [FieldOffset(0)]
        public D3D11_VIDEO_COLOR_RGBA RGBA;
    }
    
    public _Anonymous_e__Union Anonymous;
}
