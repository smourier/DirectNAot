#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/aviriff/ns-aviriff-avistreamheader
[StructLayout(LayoutKind.Sequential)]
public partial struct AVISTREAMHEADER
{
    [StructLayout(LayoutKind.Sequential)]
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
