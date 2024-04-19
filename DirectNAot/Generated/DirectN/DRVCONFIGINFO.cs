namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mmiscapi/ns-mmiscapi-drvconfiginfo
[StructLayout(LayoutKind.Sequential)]
public partial struct DRVCONFIGINFO
{
    public uint dwDCISize;
    public PWSTR lpszDCISectionName;
    public PWSTR lpszDCIAliasName;
}
