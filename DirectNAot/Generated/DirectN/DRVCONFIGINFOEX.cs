#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DRVCONFIGINFOEX
{
    public uint dwDCISize;
    public PWSTR lpszDCISectionName;
    public PWSTR lpszDCIAliasName;
    public uint dnDevNode;
}
