﻿#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DIRTYRECT_INFO
{
    public uint FrameNumber;
    public uint NumDirtyRects;
    public InlineArrayRECT_1 DirtyRects; // variable-length array placeholder
}