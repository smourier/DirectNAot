﻿namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSPROPERTY_VIDEOCONTROL_FRAME_RATES_S
{
    public KSIDENTIFIER Property;
    public uint StreamIndex;
    public uint RangeIndex;
    public FoundationSIZE Dimensions;
}
