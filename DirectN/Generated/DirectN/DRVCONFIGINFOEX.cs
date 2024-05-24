#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct DRVCONFIGINFOEX
{
    public uint dwDCISize;
    public PWSTR lpszDCISectionName;
    public PWSTR lpszDCIAliasName;
    public uint dnDevNode;
}
