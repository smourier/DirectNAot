#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xaudio2/ns-xaudio2-xaudio2_debug_configuration
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct XAUDIO2_DEBUG_CONFIGURATION
{
    public uint TraceMask;
    public uint BreakMask;
    public BOOL LogThreadID;
    public BOOL LogFileline;
    public BOOL LogFunctionName;
    public BOOL LogTiming;
}
