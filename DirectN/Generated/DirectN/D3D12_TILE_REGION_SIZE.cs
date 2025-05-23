﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_tile_region_size
public partial struct D3D12_TILE_REGION_SIZE
{
    public uint NumTiles;
    public BOOL UseBox;
    public uint Width;
    public ushort Height;
    public ushort Depth;
}
