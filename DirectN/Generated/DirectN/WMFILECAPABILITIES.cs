﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/WMDM/wmfilecapabilities
public partial struct WMFILECAPABILITIES
{
    public PWSTR pwszMimeType;
    public uint dwReserved;
}
