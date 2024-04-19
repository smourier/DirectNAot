﻿namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSM_BDA_DEBUG_LEVEL
{
    public KSIDENTIFIER Method;
    public byte ucDebugLevel;
    public uint ulDebugStringSize;
    public InlineArrayByte1 argbDebugString; // variable-length array placeholder
}
