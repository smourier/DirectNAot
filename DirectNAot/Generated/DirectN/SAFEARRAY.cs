﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/oaidl/ns-oaidl-safearray
[StructLayout(LayoutKind.Sequential)]
public partial struct SAFEARRAY
{
    public ushort cDims;
    public ADVANCED_FEATURE_FLAGS fFeatures;
    public uint cbElements;
    public uint cLocks;
    public nint pvData;
    public InlineArraySAFEARRAYBOUND1 rgsabound; // variable-length array placeholder
}
