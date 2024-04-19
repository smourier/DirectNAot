namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxvahd/ns-dxvahd-dxvahd_color_ycbcra
[StructLayout(LayoutKind.Sequential)]
public partial struct DXVAHD_COLOR_YCbCrA
{
    public float Y;
    public float Cb;
    public float Cr;
    public float A;
}
