namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3DEXECUTEBUFFERDESC
{
    public uint dwSize;
    public uint dwFlags;
    public uint dwCaps;
    public uint dwBufferSize;
    public nint lpData;
}
