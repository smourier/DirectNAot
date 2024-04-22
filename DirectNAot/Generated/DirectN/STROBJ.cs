﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winddi/ns-winddi-strobj
[StructLayout(LayoutKind.Sequential)]
public partial struct STROBJ
{
    public uint cGlyphs;
    public uint flAccel;
    public uint ulCharInc;
    public RECTL rclBkGround;
    public nint pgp;
    public PWSTR pwszOrg;
}
