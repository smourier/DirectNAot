﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxcore_interface/ns-dxcore_interface-dxcoreadaptermemorybudgetnodesegmentgroup
public partial struct DXCoreAdapterMemoryBudgetNodeSegmentGroup
{
    public uint nodeIndex;
    public DXCoreSegmentGroup segmentGroup;
}
