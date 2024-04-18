﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11sdklayers/nn-d3d11sdklayers-id3d11switchtoref
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("1ef337e3-58e7-4f83-a692-db221f5ed47e")]
public partial interface ID3D11SwitchToRef
{
    // https://learn.microsoft.com/windows/win32/api/d3d11sdklayers/nf-d3d11sdklayers-id3d11switchtoref-setuseref
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    public bool SetUseRef([MarshalAs(UnmanagedType.U4)] bool UseRef);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11sdklayers/nf-d3d11sdklayers-id3d11switchtoref-getuseref
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    public bool GetUseRef();
}
