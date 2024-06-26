﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vfw/ns-vfw-avifileinfoa
public partial struct AVIFILEINFOA
{
    public uint dwMaxBytesPerSec;
    public uint dwFlags;
    public uint dwCaps;
    public uint dwStreams;
    public uint dwSuggestedBufferSize;
    public uint dwWidth;
    public uint dwHeight;
    public uint dwScale;
    public uint dwRate;
    public uint dwLength;
    public uint dwEditCount;
    public InlineArrayFoundationCHAR_64 szFileType;
}
