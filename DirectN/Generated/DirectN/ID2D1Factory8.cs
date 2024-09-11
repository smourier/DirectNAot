#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("677c9311-f36d-4b1f-ae86-86d1223ffd3a")]
public partial interface ID2D1Factory8 : ID2D1Factory7
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateDevice([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDXGIDevice>))] IDXGIDevice dxgiDevice, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1Device7>))] out ID2D1Device7 d2dDevice6);
}
