﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dcomptypes/ns-dcomptypes-composition_frame_stats
[StructLayout(LayoutKind.Sequential)]
public partial struct COMPOSITION_FRAME_STATS
{
    public ulong startTime;
    public ulong targetTime;
    public ulong framePeriod;
}
