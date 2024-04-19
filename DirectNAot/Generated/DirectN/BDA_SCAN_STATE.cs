namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct BDA_SCAN_STATE
{
    public int lResult;
    public uint ulSignalLock;
    public uint ulSecondsLeft;
    public uint ulCurrentFrequency;
}
