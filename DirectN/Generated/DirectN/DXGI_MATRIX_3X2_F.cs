#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi1_3/ns-dxgi1_3-dxgi_matrix_3x2_f
[StructLayout(LayoutKind.Sequential)]
public partial struct DXGI_MATRIX_3X2_F
{
    public float _11;
    public float _12;
    public float _21;
    public float _22;
    public float _31;
    public float _32;
}
