namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi/ns-dxgi-dxgi_surface_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct DXGI_SURFACE_DESC
{
    public uint Width;
    public uint Height;
    public DXGI_FORMAT Format;
    public DXGI_SAMPLE_DESC SampleDesc;
}
