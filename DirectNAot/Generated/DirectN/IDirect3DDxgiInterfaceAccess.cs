#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/windows.graphics.directx.direct3d11.interop/ns-windows-graphics-directx-direct3d11-interop-idirect3ddxgiinterfaceaccess
[GeneratedComInterface, Guid("a9b3d012-3df2-4ee3-b8d1-8695f457d3c1")]
public partial interface IDirect3DDxgiInterfaceAccess
{
    // https://learn.microsoft.com/windows/win32/api/windows.graphics.directx.direct3d11.interop/nf-windows-graphics-directx-direct3d11-interop-idirect3ddxgiinterfaceaccess-getinterface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetInterface(in Guid iid, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<object>))] out object /* void */ p);
}
