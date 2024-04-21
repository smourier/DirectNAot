﻿namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct NABTS_BUFFER
{
    public VBICODECFILTERING_SCANLINES ScanlinesRequested;
    public long PictureNumber;
    public InlineArrayNABTS_BUFFER_LINE11 NabtsLines;
}