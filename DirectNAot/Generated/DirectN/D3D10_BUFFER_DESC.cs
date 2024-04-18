namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10/ns-d3d10-d3d10_buffer_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D10_BUFFER_DESC
{
    public uint ByteWidth;
    public D3D10_USAGE Usage;
    public uint BindFlags;
    public uint CPUAccessFlags;
    public uint MiscFlags;
}
