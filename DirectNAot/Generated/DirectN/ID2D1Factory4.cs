﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1_3/nn-d2d1_3-id2d1factory4
[GeneratedComInterface, Guid("bd4ec2d2-0662-4bee-ba8e-6f29f032e096")]
public partial interface ID2D1Factory4 : ID2D1Factory3
{
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1factory4-createdevice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateDevice(IDXGIDevice dxgiDevice, out ID2D1Device3 d2dDevice3);
}
