namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KS_VIDEOINFO
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public InlineArrayKS_RGBQUAD256 bmiColors;
        
        [FieldOffset(0)]
        public InlineArrayUInt323 dwBitMasks;
        
        [FieldOffset(0)]
        public KS_TRUECOLORINFO TrueColorInfo;
    }
    
    public RECT rcSource;
    public RECT rcTarget;
    public uint dwBitRate;
    public uint dwBitErrorRate;
    public long AvgTimePerFrame;
    public KS_BITMAPINFOHEADER bmiHeader;
    public _Anonymous_e__Union Anonymous;
}
