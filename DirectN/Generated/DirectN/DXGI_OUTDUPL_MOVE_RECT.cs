﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi1_2/ns-dxgi1_2-dxgi_outdupl_move_rect
public partial struct DXGI_OUTDUPL_MOVE_RECT
{
    public POINT SourcePoint;
    public RECT DestinationRect;
}
