#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mmiscapi/ns-mmiscapi-drvconfiginfo
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct DRVCONFIGINFO
{
    public uint dwDCISize;
    public PWSTR lpszDCISectionName;
    public PWSTR lpszDCIAliasName;
}
