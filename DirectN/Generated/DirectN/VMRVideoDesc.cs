﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ns-strmif-vmrvideodesc
[StructLayout(LayoutKind.Sequential)]
public partial struct VMRVideoDesc
{
    public uint dwSize;
    public uint dwSampleWidth;
    public uint dwSampleHeight;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool SingleFieldPerSample;
    public uint dwFourCC;
    public VMRFrequency InputSampleFreq;
    public VMRFrequency OutputFrameFreq;
}