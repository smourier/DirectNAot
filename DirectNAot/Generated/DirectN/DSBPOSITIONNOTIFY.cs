namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DSBPOSITIONNOTIFY
{
    public uint dwOffset;
    public HANDLE hEventNotify;
}
