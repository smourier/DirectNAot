#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1_3/nn-d2d1_3-id2d1factory5
[GeneratedComInterface, Guid("c4349994-838e-4b0f-8cab-44997d9eeacc")]
public partial interface ID2D1Factory5 : ID2D1Factory4
{
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1factory5-createdevice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateDevice(IDXGIDevice dxgiDevice, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1Device4>))] out ID2D1Device4 d2dDevice4);
}
