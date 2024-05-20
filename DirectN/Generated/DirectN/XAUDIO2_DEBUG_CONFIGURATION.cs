#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xaudio2/ns-xaudio2-xaudio2_debug_configuration
[StructLayout(LayoutKind.Sequential)]
public partial struct XAUDIO2_DEBUG_CONFIGURATION
{
    public uint TraceMask;
    public uint BreakMask;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool LogThreadID;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool LogFileline;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool LogFunctionName;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool LogTiming;
}
