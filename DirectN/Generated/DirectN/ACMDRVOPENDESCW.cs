#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct ACMDRVOPENDESCW
{
    public uint cbStruct;
    public uint fccType;
    public uint fccComp;
    public uint dwVersion;
    public uint dwFlags;
    public uint dwError;
    public PWSTR pszSectionName;
    public PWSTR pszAliasName;
    public uint dnDevNode;
}
