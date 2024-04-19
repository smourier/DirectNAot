namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSPROPERTY_BDA_RF_TUNER_STANDARD_MODE_S
{
    public KSP_NODE Property;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool AutoDetect;
}
