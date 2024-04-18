namespace DirectN;

// https://learn.microsoft.com/windows/win32/printdocs/printer-notify-options
[StructLayout(LayoutKind.Sequential)]
public partial struct PRINTER_NOTIFY_OPTIONS
{
    public uint Version;
    public uint Flags;
    public uint Count;
    public nint pTypes;
}
