namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSCAMERA_EXTENDEDPROP_BACKGROUNDSEGMENTATION_CONFIGCAPS
{
    [StructLayout(LayoutKind.Sequential)]
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
