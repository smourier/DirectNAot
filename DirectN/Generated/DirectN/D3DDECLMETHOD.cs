﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/direct3d9/d3ddeclmethod
public enum D3DDECLMETHOD
{
    D3DDECLMETHOD_DEFAULT = 0,
    D3DDECLMETHOD_PARTIALU = 1,
    D3DDECLMETHOD_PARTIALV = 2,
    D3DDECLMETHOD_CROSSUV = 3,
    D3DDECLMETHOD_UV = 4,
    D3DDECLMETHOD_LOOKUP = 5,
    D3DDECLMETHOD_LOOKUPPRESAMPLED = 6,
}
