﻿namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DxcArgPair
{
    public PWSTR pName;
    public PWSTR pValue;
}