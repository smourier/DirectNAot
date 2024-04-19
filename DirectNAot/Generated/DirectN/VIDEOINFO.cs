namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/amvideo/ns-amvideo-videoinfo
[StructLayout(LayoutKind.Sequential)]
public partial struct VIDEOINFO
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public InlineArrayRGBQUAD256 bmiColors;
        
        [FieldOffset(0)]
        public InlineArrayUInt323 dwBitMasks;
        
        [FieldOffset(0)]
        public TRUECOLORINFO TrueColorInfo;
    }
    
    public FoundationRECT rcSource;
    public FoundationRECT rcTarget;
    public uint dwBitRate;
    public uint dwBitErrorRate;
    public long AvgTimePerFrame;
    public BITMAPINFOHEADER bmiHeader;
    public _Anonymous_e__Union Anonymous;
}
