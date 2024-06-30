#nullable enable
namespace DirectN;

public partial struct KSM_BDA_SCAN_FILTER
{
    public KSIDENTIFIER Method;
    public uint ulScanModulationTypeSize;
    public ulong AnalogVideoStandards;
    public InlineArrayByte_1 argbScanModulationTypes; // variable-length array placeholder
}
