namespace DirectN;

// https://learn.microsoft.com/windows/win32/direct3ddxgi/dxgi-rgba
[StructLayout(LayoutKind.Sequential)]
public partial struct DXGI_RGBA
{
    public float r;
    public float g;
    public float b;
    public float a;
}
