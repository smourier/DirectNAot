#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSPROPERTY_TUNER_STANDARD_MODE_S
{
    public KSIDENTIFIER Property;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool AutoDetect;
}
