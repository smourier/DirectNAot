﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-monitorinfoexw
public partial struct MONITORINFOEXW
{
    public MONITORINFO monitorInfo;
    public InlineArraySystemChar_32 szDevice;
}
