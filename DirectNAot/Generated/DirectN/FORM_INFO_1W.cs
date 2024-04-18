namespace DirectN;

// https://learn.microsoft.com/windows/win32/printdocs/form-info-1
[StructLayout(LayoutKind.Sequential)]
public partial struct FORM_INFO_1W
{
    public uint Flags;
    public PWSTR pName;
    public nint Size;
    public RECTL ImageableArea;
}
