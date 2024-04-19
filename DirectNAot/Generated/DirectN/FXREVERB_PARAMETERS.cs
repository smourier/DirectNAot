﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xapofx/ns-xapofx-fxreverb_parameters
[StructLayout(LayoutKind.Sequential)]
public partial struct FXREVERB_PARAMETERS
{
    public float Diffusion;
    public float RoomSize;
}
