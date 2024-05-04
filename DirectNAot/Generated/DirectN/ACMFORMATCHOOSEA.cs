﻿#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct ACMFORMATCHOOSEA
{
    public uint cbStruct;
    public uint fdwStyle;
    public HWND hwndOwner;
    public nint pwfx;
    public uint cbwfx;
    public PSTR pszTitle;
    public InlineArrayFoundationCHAR48 szFormatTag;
    public InlineArrayFoundationCHAR128 szFormat;
    public PSTR pszName;
    public uint cchName;
    public uint fdwEnum;
    public nint pwfxEnum;
    public HINSTANCE hInstance;
    public PSTR pszTemplateName;
    public LPARAM lCustData;
    public nint pfnHook;
}
