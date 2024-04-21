﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vfw/ns-vfw-avistreaminfoa
[StructLayout(LayoutKind.Sequential)]
public partial struct AVISTREAMINFOA
{
    public uint fccType;
    public uint fccHandler;
    public uint dwFlags;
    public uint dwCaps;
    public ushort wPriority;
    public ushort wLanguage;
    public uint dwScale;
    public uint dwRate;
    public uint dwStart;
    public uint dwLength;
    public uint dwInitialFrames;
    public uint dwSuggestedBufferSize;
    public uint dwQuality;
    public uint dwSampleSize;
    public FoundationRECT rcFrame;
    public uint dwEditCount;
    public uint dwFormatChangeCount;
    public InlineArrayFoundationCHAR64 szName;
}