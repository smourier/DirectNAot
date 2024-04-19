﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mmiscapi/ns-mmiscapi-mmckinfo
[StructLayout(LayoutKind.Sequential)]
public partial struct MMCKINFO
{
    public uint ckid;
    public uint cksize;
    public uint fccType;
    public uint dwDataOffset;
    public uint dwFlags;
}
