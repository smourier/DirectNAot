﻿namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DMUS_WAVES_REVERB_PARAMS
{
    public float fInGain;
    public float fReverbMix;
    public float fReverbTime;
    public float fHighFreqRTRatio;
}
