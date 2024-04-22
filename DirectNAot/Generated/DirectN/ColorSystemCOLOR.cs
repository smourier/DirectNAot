namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/icm/ns-icm-color
[StructLayout(LayoutKind.Explicit)]
public partial struct ColorSystemCOLOR
{
    [StructLayout(LayoutKind.Sequential)]
    public struct _Anonymous_e__Struct
    {
        public uint reserved1;
        public nint reserved2;
    }
    
    [FieldOffset(0)]
    public GRAYCOLOR gray;
    
    [FieldOffset(0)]
    public RGBCOLOR rgb;
    
    [FieldOffset(0)]
    public CMYKCOLOR cmyk;
    
    [FieldOffset(0)]
    public XYZCOLOR XYZ;
    
    [FieldOffset(0)]
    public YxyCOLOR Yxy;
    
    [FieldOffset(0)]
    public LabCOLOR Lab;
    
    [FieldOffset(0)]
    public GENERIC3CHANNEL gen3ch;
    
    [FieldOffset(0)]
    public NAMEDCOLOR named;
    
    [FieldOffset(0)]
    public HiFiCOLOR hifi;
    
    [FieldOffset(0)]
    public _Anonymous_e__Struct Anonymous;
}
