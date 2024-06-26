﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10/ns-d3d10-d3d10_counter_info
public partial struct D3D10_COUNTER_INFO
{
    public D3D10_COUNTER LastDeviceDependentCounter;
    public uint NumSimultaneousCounters;
    public byte NumDetectableParallelUnits;
}
