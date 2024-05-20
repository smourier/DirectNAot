﻿#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DSFXFlanger
{
    public float fWetDryMix;
    public float fDepth;
    public float fFeedback;
    public float fFrequency;
    public int lWaveform;
    public float fDelay;
    public int lPhase;
}