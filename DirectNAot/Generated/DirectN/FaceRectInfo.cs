﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfapi/ns-mfapi-facerectinfo
[StructLayout(LayoutKind.Sequential)]
public partial struct FaceRectInfo
{
    public FoundationRECT Region;
    public int confidenceLevel;
}
