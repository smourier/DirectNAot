﻿namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSPROPERTY_TUNER_MODE_CAPS_S
{
    public KSIDENTIFIER Property;
    public uint Mode;
    public uint StandardsSupported;
    public uint MinFrequency;
    public uint MaxFrequency;
    public uint TuningGranularity;
    public uint NumberOfInputs;
    public uint SettlingTime;
    public uint Strategy;
}
