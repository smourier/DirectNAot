namespace DirectN;

// https://learn.microsoft.com/windows/win32/printdocs/printprocessor-info-1
[StructLayout(LayoutKind.Sequential)]
public partial struct PRINTPROCESSOR_INFO_1A
{
    public PSTR pName;
}
