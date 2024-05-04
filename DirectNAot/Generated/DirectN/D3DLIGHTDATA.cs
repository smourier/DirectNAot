#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3DLIGHTDATA
{
    public uint dwSize;
    public nint lpIn;
    public uint dwInSize;
    public nint lpOut;
    public uint dwOutSize;
}
