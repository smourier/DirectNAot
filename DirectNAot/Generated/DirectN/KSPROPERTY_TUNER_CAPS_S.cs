﻿namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSPROPERTY_TUNER_CAPS_S
{
    public KSIDENTIFIER Property;
    public uint ModesSupported;
    public KSIDENTIFIER VideoMedium;
    public KSIDENTIFIER TVAudioMedium;
    public KSIDENTIFIER RadioAudioMedium;
}
