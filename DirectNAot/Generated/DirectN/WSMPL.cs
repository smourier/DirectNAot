﻿namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct WSMPL
{
    public uint cbSize;
    public ushort usUnityNote;
    public short sFineTune;
    public int lAttenuation;
    public uint fulOptions;
    public uint cSampleLoops;
}
