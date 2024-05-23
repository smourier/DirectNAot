#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1_2/nn-d2d1_2-id2d1factory2
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("94f81a73-9212-4376-9c58-b16a3a0d3992")]
public partial interface ID2D1Factory2 : ID2D1Factory1
{
    // https://learn.microsoft.com/windows/win32/api/d2d1_2/nf-d2d1_2-id2d1factory2-createdevice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateDevice(IDXGIDevice dxgiDevice, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1Device1>))] out ID2D1Device1 d2dDevice1);
}
