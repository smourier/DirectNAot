#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/amvideo/ns-amvideo-videoinfo
public partial struct VIDEOINFO
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public InlineArrayRGBQUAD_256 bmiColors;
        
        [FieldOffset(0)]
        public InlineArrayUInt32_3 dwBitMasks;
        
        [FieldOffset(0)]
        public TRUECOLORINFO TrueColorInfo;
    }
    
    public RECT rcSource;
    public RECT rcTarget;
    public uint dwBitRate;
    public uint dwBitErrorRate;
    public long AvgTimePerFrame;
    public BITMAPINFOHEADER bmiHeader;
    public _Anonymous_e__Union Anonymous;
}
