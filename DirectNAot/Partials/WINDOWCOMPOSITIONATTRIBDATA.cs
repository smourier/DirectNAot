﻿namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public struct WINDOWCOMPOSITIONATTRIBDATA
{
    public WINDOWCOMPOSITIONATTRIB dwAttrib;
    public IntPtr pvData;
    public IntPtr cbData;
}
