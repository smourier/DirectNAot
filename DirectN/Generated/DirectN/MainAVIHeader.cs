﻿#nullable enable
namespace DirectN;

public partial struct MainAVIHeader
{
    public uint dwMicroSecPerFrame;
    public uint dwMaxBytesPerSec;
    public uint dwPaddingGranularity;
    public uint dwFlags;
    public uint dwTotalFrames;
    public uint dwInitialFrames;
    public uint dwStreams;
    public uint dwSuggestedBufferSize;
    public uint dwWidth;
    public uint dwHeight;
    public InlineArrayUInt32_4 dwReserved;
}
