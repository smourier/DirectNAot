#nullable enable
namespace DirectN;

// https://learn.microsoft.com/previous-versions/windows/desktop/api/aviriff/ns-aviriff-avistreamheader
[StructLayout(LayoutKind.Sequential, Pack = 2)]
public partial struct AVISTREAMHEADER
{
    public struct _rcFrame_e__Struct
    {
        public short left;
        public short top;
        public short right;
        public short bottom;
    }
    
    public uint fcc;
    public uint cb;
    public uint fccType;
    public uint fccHandler;
    public uint dwFlags;
    public ushort wPriority;
    public ushort wLanguage;
    public uint dwInitialFrames;
    public uint dwScale;
    public uint dwRate;
    public uint dwStart;
    public uint dwLength;
    public uint dwSuggestedBufferSize;
    public uint dwQuality;
    public uint dwSampleSize;
    public _rcFrame_e__Struct rcFrame;
}
