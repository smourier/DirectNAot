﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dvdmedia/ns-dvdmedia-videoinfoheader2
public partial struct VIDEOINFOHEADER2
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public uint dwControlFlags;
        
        [FieldOffset(0)]
        public uint dwReserved1;
    }
    
    public RECT rcSource;
    public RECT rcTarget;
    public uint dwBitRate;
    public uint dwBitErrorRate;
    public long AvgTimePerFrame;
    public uint dwInterlaceFlags;
    public uint dwCopyProtectFlags;
    public uint dwPictAspectRatioX;
    public uint dwPictAspectRatioY;
    public _Anonymous_e__Union Anonymous;
    public uint dwReserved2;
    public BITMAPINFOHEADER bmiHeader;
}
