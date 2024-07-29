#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi1_2/nn-dxgi1_2-idxgisurface2
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("aba496dd-b617-4cb8-a866-bc44d7eb1fa2")]
public partial interface IDXGISurface2 : IDXGISurface1
{
    // https://learn.microsoft.com/windows/win32/api/dxgi1_2/nf-dxgi1_2-idxgisurface2-getresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetResource(in Guid riid, out nint /* void */ ppParentResource, out uint pSubresourceIndex);
}
