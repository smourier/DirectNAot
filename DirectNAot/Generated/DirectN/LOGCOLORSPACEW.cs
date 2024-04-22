﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-logcolorspacew
[StructLayout(LayoutKind.Sequential)]
public partial struct LOGCOLORSPACEW
{
    public uint lcsSignature;
    public uint lcsVersion;
    public uint lcsSize;
    public LCSCSTYPE lcsCSType;
    public int lcsIntent;
    public CIEXYZTRIPLE lcsEndpoints;
    public uint lcsGammaRed;
    public uint lcsGammaGreen;
    public uint lcsGammaBlue;
    public InlineArraySystemChar260 lcsFilename;
}
