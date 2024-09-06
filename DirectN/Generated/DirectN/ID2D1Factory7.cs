#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1_3/nn-d2d1_3-id2d1factory7
[GeneratedComInterface, Guid("bdc2bdd3-b96c-4de6-bdf7-99d4745454de")]
public partial interface ID2D1Factory7 : ID2D1Factory6
{
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1factory7-createdevice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateDevice(IDXGIDevice dxgiDevice, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1Device6>))] out ID2D1Device6 d2dDevice6);
}
