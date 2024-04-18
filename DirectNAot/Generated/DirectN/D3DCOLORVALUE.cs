namespace DirectN;

// https://learn.microsoft.com/windows/win32/direct3ddxgi/d3dcolorvalue
[StructLayout(LayoutKind.Sequential)]
public partial struct D3DCOLORVALUE
{
    public float r;
    public float g;
    public float b;
    public float a;
}
