﻿namespace DirectN;

[GeneratedComInterface, Guid("5e13e843-9d25-473c-9ad2-03b2d0b44b1e")]
public partial interface IDxcVersionInfo3
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetCustomVersionString(out sbyte pVersionString);
}
