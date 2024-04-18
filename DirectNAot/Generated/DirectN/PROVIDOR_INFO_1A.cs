namespace DirectN;

// https://learn.microsoft.com/windows/win32/printdocs/providor-info-1
[StructLayout(LayoutKind.Sequential)]
public partial struct PROVIDOR_INFO_1A
{
    public PSTR pName;
    public PSTR pEnvironment;
    public PSTR pDLLName;
}
