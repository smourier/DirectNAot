namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSM_BDA_SCAN_FILTER
{
    public KSIDENTIFIER Method;
    public uint ulScanModulationTypeSize;
    public ulong AnalogVideoStandards;
    public InlineArrayByte1 argbScanModulationTypes; // variable-length array placeholder
}
