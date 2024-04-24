﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincrypt/ns-wincrypt-crypt_bit_blob
[StructLayout(LayoutKind.Sequential)]
public partial struct CRYPT_BIT_BLOB
{
    public uint cbData;
    public nint pbData;
    public uint cUnusedBits;
}