namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct PROPSHEETUI_GETICON_INFO
{
    public ushort cbSize;
    public ushort Flags;
    public ushort cxIcon;
    public ushort cyIcon;
    public HICON hIcon;
}
