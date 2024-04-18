namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct PRINTER_EVENT_ATTRIBUTES_INFO
{
    public uint cbSize;
    public uint dwOldAttributes;
    public uint dwNewAttributes;
}
