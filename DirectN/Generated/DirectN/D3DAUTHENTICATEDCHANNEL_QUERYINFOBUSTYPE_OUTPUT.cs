﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/medfound/d3dauthenticatedchannel-queryinfobustype-output
public partial struct D3DAUTHENTICATEDCHANNEL_QUERYINFOBUSTYPE_OUTPUT
{
    public D3DAUTHENTICATEDCHANNEL_QUERY_OUTPUT Output;
    public D3DBUSTYPE BusType;
    public BOOL bAccessibleInContiguousBlocks;
    public BOOL bAccessibleInNonContiguousBlocks;
}
