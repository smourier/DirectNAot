#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ns-strmif-timecode
[StructLayout(LayoutKind.Explicit)]
public partial struct TIMECODE
{
    public struct _Anonymous_e__Struct
    {
        public ushort wFrameRate;
        public ushort wFrameFract;
        public uint dwFrames;
    }
    
    [FieldOffset(0)]
    public _Anonymous_e__Struct Anonymous;
    
    [FieldOffset(0)]
    public ulong qw;
}
