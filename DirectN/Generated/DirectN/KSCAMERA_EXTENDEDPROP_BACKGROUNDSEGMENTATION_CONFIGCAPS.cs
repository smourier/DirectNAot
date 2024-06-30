#nullable enable
namespace DirectN;

public partial struct KSCAMERA_EXTENDEDPROP_BACKGROUNDSEGMENTATION_CONFIGCAPS
{
    public struct _MaxFrameRate_e__Struct
    {
        public int Numerator;
        public int Denominator;
    }
    
    public SIZE Resolution;
    public _MaxFrameRate_e__Struct MaxFrameRate;
    public SIZE MaskResolution;
    public Guid SubType;
}
