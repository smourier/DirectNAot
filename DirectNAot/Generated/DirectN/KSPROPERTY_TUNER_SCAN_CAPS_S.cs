namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSPROPERTY_TUNER_SCAN_CAPS_S
{
    public KSIDENTIFIER Property;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool fSupportsHardwareAssistedScanning;
    public uint SupportedBroadcastStandards;
    public nint GUIDBucket;
    public uint lengthofBucket;
}
