﻿#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct ACMDRVOPENDESCA
{
    public uint cbStruct;
    public uint fccType;
    public uint fccComp;
    public uint dwVersion;
    public uint dwFlags;
    public uint dwError;
    public PSTR pszSectionName;
    public PSTR pszAliasName;
    public uint dnDevNode;
}
