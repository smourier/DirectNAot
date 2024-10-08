﻿#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("be7017c6-ce34-4901-8106-770381aa6e3e")]
public partial interface IWMPNodeWindowlessHost
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InvalidateRect(in RECT prc, BOOL fErase);
}
