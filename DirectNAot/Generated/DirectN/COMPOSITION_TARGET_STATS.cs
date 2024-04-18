namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dcomptypes/ns-dcomptypes-composition_target_stats
[StructLayout(LayoutKind.Sequential)]
public partial struct COMPOSITION_TARGET_STATS
{
    public uint outstandingPresents;
    public ulong presentTime;
    public ulong vblankDuration;
    public COMPOSITION_STATS presentedStats;
    public COMPOSITION_STATS completedStats;
}
