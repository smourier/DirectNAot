#nullable enable
namespace DirectN;

public partial struct D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_SUBREGIONS_LAYOUT_DATA_TILES
{
    public ulong RowCount;
    public ulong ColCount;
    public InlineArrayUInt64_64 RowHeights;
    public InlineArrayUInt64_64 ColWidths;
    public ulong ContextUpdateTileId;
}
