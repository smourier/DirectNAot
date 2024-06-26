﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/direct3d9/d3dpresentstats
public partial struct D3DPRESENTSTATS
{
    public uint PresentCount;
    public uint PresentRefreshCount;
    public uint SyncRefreshCount;
    public long SyncQPCTime;
    public long SyncGPUTime;
}
