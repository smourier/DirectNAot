namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/amva/ns-amva-amvabeginframeinfo
[StructLayout(LayoutKind.Sequential)]
public partial struct AMVABeginFrameInfo
{
    public uint dwDestSurfaceIndex;
    public nint pInputData;
    public uint dwSizeInputData;
    public nint pOutputData;
    public uint dwSizeOutputData;
}
