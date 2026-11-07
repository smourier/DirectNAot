#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("98ec0b90-2b18-42a6-9fcf-43b46f654022")]
public partial interface IDXGIFactoryMedia2 : IDXGIFactoryMedia
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateSwapChainForCompositionSurfaceHandle1(nint pDevice, HANDLE hSurface, in DXGI_SWAP_CHAIN_DESC2 pDesc, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDXGIOutput?>))] IDXGIOutput? pRestrictToOutput, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDXGISwapChain5>))] out IDXGISwapChain5 ppSwapChain);
}
