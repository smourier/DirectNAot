#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct BDA_SCAN_CAPABILTIES
{
    public int lResult;
    public ulong ul64AnalogStandardsSupported;
}
