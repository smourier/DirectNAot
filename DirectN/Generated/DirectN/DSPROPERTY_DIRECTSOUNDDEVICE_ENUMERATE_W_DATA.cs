﻿#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DSPROPERTY_DIRECTSOUNDDEVICE_ENUMERATE_W_DATA
{
    public nint Callback;
    public nint Context;
}