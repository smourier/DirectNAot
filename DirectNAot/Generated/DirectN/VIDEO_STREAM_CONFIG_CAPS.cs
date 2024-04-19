﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ns-strmif-video_stream_config_caps
[StructLayout(LayoutKind.Sequential)]
public partial struct VIDEO_STREAM_CONFIG_CAPS
{
    public Guid guid;
    public uint VideoStandard;
    public FoundationSIZE InputSize;
    public FoundationSIZE MinCroppingSize;
    public FoundationSIZE MaxCroppingSize;
    public int CropGranularityX;
    public int CropGranularityY;
    public int CropAlignX;
    public int CropAlignY;
    public FoundationSIZE MinOutputSize;
    public FoundationSIZE MaxOutputSize;
    public int OutputGranularityX;
    public int OutputGranularityY;
    public int StretchTapsX;
    public int StretchTapsY;
    public int ShrinkTapsX;
    public int ShrinkTapsY;
    public long MinFrameInterval;
    public long MaxFrameInterval;
    public int MinBitsPerSecond;
    public int MaxBitsPerSecond;
}
