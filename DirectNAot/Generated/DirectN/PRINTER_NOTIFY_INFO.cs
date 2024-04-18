namespace DirectN;

// https://learn.microsoft.com/windows/win32/printdocs/printer-notify-info
[StructLayout(LayoutKind.Sequential)]
public partial struct PRINTER_NOTIFY_INFO
{
    public uint Version;
    public uint Flags;
    public uint Count;
    public InlineArrayPRINTER_NOTIFY_INFO_DATA1 aData; // variable-length array placeholder
}
