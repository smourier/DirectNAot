namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_colorcontroldata
[StructLayout(LayoutKind.Sequential)]
public partial struct DD_COLORCONTROLDATA
{
    public nint lpDD;
    public nint lpDDSurface;
    public nint lpColorData;
    public uint dwFlags;
    public HRESULT ddRVal;
    public nint ColorControl;
}
