#nullable enable
namespace DirectN;

public partial struct D3D12_TEXTURE_COPY_REGION
{
    public uint DestX;
    public uint DestY;
    public uint DestZ;
    public nint pSourceBox;
}
