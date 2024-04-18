namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dcomptypes/ns-dcomptypes-composition_stats
[StructLayout(LayoutKind.Sequential)]
public partial struct COMPOSITION_STATS
{
    public uint presentCount;
    public uint refreshCount;
    public uint virtualRefreshCount;
    public ulong time;
}
