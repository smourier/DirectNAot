namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct PRINTER_NOTIFY_INIT
{
    public uint Size;
    public uint Reserved;
    public uint PollTime;
}
