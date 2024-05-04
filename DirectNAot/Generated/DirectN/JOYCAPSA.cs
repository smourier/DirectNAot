﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/joystickapi/ns-joystickapi-joycapsa
[StructLayout(LayoutKind.Sequential)]
public partial struct JOYCAPSA
{
    public ushort wMid;
    public ushort wPid;
    public InlineArrayFoundationCHAR32 szPname;
    public uint wXmin;
    public uint wXmax;
    public uint wYmin;
    public uint wYmax;
    public uint wZmin;
    public uint wZmax;
    public uint wNumButtons;
    public uint wPeriodMin;
    public uint wPeriodMax;
    public uint wRmin;
    public uint wRmax;
    public uint wUmin;
    public uint wUmax;
    public uint wVmin;
    public uint wVmax;
    public uint wCaps;
    public uint wMaxAxes;
    public uint wNumAxes;
    public uint wMaxButtons;
    public InlineArrayFoundationCHAR32 szRegKey;
    public InlineArrayFoundationCHAR260 szOEMVxD;
}
