#nullable enable
namespace DirectN;

public partial struct KSCAMERA_PROFILE_MEDIAINFO
{
    public struct _MaxFrameRate_e__Struct
    {
        public uint Numerator;
        public uint Denominator;
    }
    
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
