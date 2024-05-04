#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSM_BDA_SCAN_START
{
    public KSIDENTIFIER Method;
    public uint LowerFrequency;
    public uint HigherFrequency;
}
