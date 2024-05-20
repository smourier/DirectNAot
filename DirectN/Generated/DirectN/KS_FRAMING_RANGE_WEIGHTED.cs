﻿#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KS_FRAMING_RANGE_WEIGHTED
{
    public KS_FRAMING_RANGE Range;
    public uint InPlaceWeight;
    public uint NotInPlaceWeight;
}
