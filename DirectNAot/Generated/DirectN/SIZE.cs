﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/windef/ns-windef-size
[StructLayout(LayoutKind.Sequential)]
public partial struct SIZE
{
    public int cx;
    public int cy;
}