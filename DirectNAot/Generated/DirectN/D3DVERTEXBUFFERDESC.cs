namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3DVERTEXBUFFERDESC
{
    public uint dwSize;
    public uint dwCaps;
    public uint dwFVF;
    public uint dwNumVertices;
}
