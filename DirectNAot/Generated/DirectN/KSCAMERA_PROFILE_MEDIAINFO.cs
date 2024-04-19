namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSCAMERA_PROFILE_MEDIAINFO
{
    [StructLayout(LayoutKind.Sequential)]
    public struct _MaxFrameRate_e__Struct
    {
        public uint Numerator;
        public uint Denominator;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct _Resolution_e__Struct
    {
        public uint X;
        public uint Y;
    }
    
    public _Resolution_e__Struct Resolution;
    public _MaxFrameRate_e__Struct MaxFrameRate;
    public ulong Flags;
    public uint Data0;
    public uint Data1;
    public uint Data2;
    public uint Data3;
}
