﻿namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSCAMERA_EXTENDEDPROP_ROI_FOCUS
{
    public KSCAMERA_EXTENDEDPROP_ROI_INFO ROIInfo;
    public ulong Reserved;
}
