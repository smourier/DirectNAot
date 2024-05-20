﻿#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct BDA_RATING_PINRESET
{
    public byte bPinLength;
    public InlineArrayByte_1 argbNewPin; // variable-length array placeholder
}