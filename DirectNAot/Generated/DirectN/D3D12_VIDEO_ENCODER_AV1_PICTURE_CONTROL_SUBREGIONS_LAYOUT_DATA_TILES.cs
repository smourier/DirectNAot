namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_SUBREGIONS_LAYOUT_DATA_TILES
{
    public ulong RowCount;
    public ulong ColCount;
    public InlineArrayUInt6464 RowHeights;
    public InlineArrayUInt6464 ColWidths;
    public ulong ContextUpdateTileId;
}
