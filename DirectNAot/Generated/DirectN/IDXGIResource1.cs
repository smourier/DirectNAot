#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi1_2/nn-dxgi1_2-idxgiresource1
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("30961379-4609-4a41-998e-54fe567ee0c1")]
public partial interface IDXGIResource1 : IDXGIResource
{
    // https://learn.microsoft.com/windows/win32/api/dxgi1_2/nf-dxgi1_2-idxgiresource1-createsubresourcesurface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateSubresourceSurface(uint index, out IDXGISurface2 ppSurface);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi1_2/nf-dxgi1_2-idxgiresource1-createsharedhandle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateSharedHandle(nint /* optional SECURITY_ATTRIBUTES* */ pAttributes, uint dwAccess, PWSTR lpName, out HANDLE pHandle);
}
