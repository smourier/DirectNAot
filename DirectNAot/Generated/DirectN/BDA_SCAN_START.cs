namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct BDA_SCAN_START
{
    public int lResult;
    public uint LowerFrequency;
    public uint HigerFrequency;
}
