﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/hrtfapoapi/ns-hrtfapoapi-hrtfdirectivitycone
[StructLayout(LayoutKind.Sequential)]
public partial struct HrtfDirectivityCone
{
    public HrtfDirectivity directivity;
    public float innerAngle;
    public float outerAngle;
}
