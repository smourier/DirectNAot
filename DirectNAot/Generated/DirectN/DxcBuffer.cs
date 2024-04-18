namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DxcBuffer
{
    public nint Ptr;
    public nuint Size;
    public uint Encoding;
}
