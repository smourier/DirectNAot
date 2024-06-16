#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DVBScramblingControlSpanningEvent
{
    public uint ulPID;
    public BOOL fScrambled;
}
