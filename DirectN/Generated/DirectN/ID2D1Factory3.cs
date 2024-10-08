﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1_3/nn-d2d1_3-id2d1factory3
[GeneratedComInterface, Guid("0869759f-4f00-413f-b03e-2bda45404d0f")]
public partial interface ID2D1Factory3 : ID2D1Factory2
{
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1factory3-createdevice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateDevice([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDXGIDevice>))] IDXGIDevice dxgiDevice, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1Device2>))] out ID2D1Device2 d2dDevice2);
}
