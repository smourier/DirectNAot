#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DVBScramblingControlSpanningEvent
{
    public uint ulPID;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool fScrambled;
}
