namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xapo/ns-xapo-xapo_lockforprocess_parameters
[StructLayout(LayoutKind.Sequential)]
public partial struct XAPO_LOCKFORPROCESS_PARAMETERS
{
    public nint pFormat;
    public uint MaxFrameCount;
}
