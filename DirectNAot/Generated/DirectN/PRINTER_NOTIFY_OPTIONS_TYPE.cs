namespace DirectN;

// https://learn.microsoft.com/windows/win32/printdocs/printer-notify-options-type
[StructLayout(LayoutKind.Sequential)]
public partial struct PRINTER_NOTIFY_OPTIONS_TYPE
{
    public ushort Type;
    public ushort Reserved0;
    public uint Reserved1;
    public uint Reserved2;
    public uint Count;
    public nint pFields;
}
