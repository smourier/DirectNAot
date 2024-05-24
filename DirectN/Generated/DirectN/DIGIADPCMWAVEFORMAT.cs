﻿#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct DIGIADPCMWAVEFORMAT
{
    public WAVEFORMATEX wfx;
    public ushort wSamplesPerBlock;
}
