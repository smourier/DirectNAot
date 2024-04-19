namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct SPEVENT
{
    public int _bitfield;
    public uint ulStreamNum;
    public ulong ullAudioStreamOffset;
    public WPARAM wParam;
    public LPARAM lParam;
}
