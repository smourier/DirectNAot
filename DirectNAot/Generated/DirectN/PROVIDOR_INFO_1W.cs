namespace DirectN;

// https://learn.microsoft.com/windows/win32/printdocs/providor-info-1
[StructLayout(LayoutKind.Sequential)]
public partial struct PROVIDOR_INFO_1W
{
    public PWSTR pName;
    public PWSTR pEnvironment;
    public PWSTR pDLLName;
}
