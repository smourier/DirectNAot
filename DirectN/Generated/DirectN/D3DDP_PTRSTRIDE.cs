#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3DDP_PTRSTRIDE
{
    public nint lpvData;
    public uint dwStride;
}
