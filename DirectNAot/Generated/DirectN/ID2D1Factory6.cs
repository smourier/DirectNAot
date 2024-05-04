#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1_3/nn-d2d1_3-id2d1factory6
[GeneratedComInterface, Guid("f9976f46-f642-44c1-97ca-da32ea2a2635")]
public partial interface ID2D1Factory6 : ID2D1Factory5
{
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1factory6-createdevice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateDevice(IDXGIDevice dxgiDevice, out ID2D1Device5 d2dDevice5);
}
