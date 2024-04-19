﻿namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct MFCameraIntrinsic_DistortionModelArcTan
{
    public float Radial_k0;
    public float DistortionCenter_x;
    public float DistortionCenter_y;
    public float Tangential_x;
    public float Tangential_y;
}
