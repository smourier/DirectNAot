﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_colorcontrolcallbacks
public partial struct DD_COLORCONTROLCALLBACKS
{
    public uint dwSize;
    public uint dwFlags;
    public nint ColorControl;
}
