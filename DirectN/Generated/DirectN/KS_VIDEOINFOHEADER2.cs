﻿#nullable enable
namespace DirectN;

public partial struct KS_VIDEOINFOHEADER2
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
    public KS_BITMAPINFOHEADER bmiHeader;
}
