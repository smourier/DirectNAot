#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct COLORSPACE_TRANSFORM
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Data_e__Union
    {
        [FieldOffset(0)]
        public GAMMA_RAMP_RGB256x3x16 Rgb256x3x16;
        
        [FieldOffset(0)]
        public GAMMA_RAMP_DXGI_1 Dxgi1;
        
        [FieldOffset(0)]
        public COLORSPACE_TRANSFORM_3x4 T3x4;
        
        [FieldOffset(0)]
        public COLORSPACE_TRANSFORM_MATRIX_V2 MatrixV2;
    }
    
    public COLORSPACE_TRANSFORM_TYPE Type;
    public _Data_e__Union Data;
}
