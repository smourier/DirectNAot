namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSRATE
{
    public long PresentationStart;
    public long Duration;
    public KSIDENTIFIER Interface;
    public int Rate;
    public uint Flags;
}
