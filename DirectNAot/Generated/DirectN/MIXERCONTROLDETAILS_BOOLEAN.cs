﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mmeapi/ns-mmeapi-mixercontroldetails_boolean
[StructLayout(LayoutKind.Sequential)]
public partial struct MIXERCONTROLDETAILS_BOOLEAN
{
    public int fValue;
}
