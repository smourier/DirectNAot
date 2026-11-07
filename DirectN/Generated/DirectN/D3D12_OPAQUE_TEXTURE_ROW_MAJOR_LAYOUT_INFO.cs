#nullable enable
namespace DirectN;

public partial struct D3D12_OPAQUE_TEXTURE_ROW_MAJOR_LAYOUT_INFO
{
    public BOOL IsRowMajor;
    public ulong Offset;
    public ulong RowPitch;
    public uint Width;
    public uint Height;
}
