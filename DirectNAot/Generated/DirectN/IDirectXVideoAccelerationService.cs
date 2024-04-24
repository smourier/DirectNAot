namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxva2api/nn-dxva2api-idirectxvideoaccelerationservice
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("fc51a550-d5e7-11d9-af55-00054e43ff02")]
public partial interface IDirectXVideoAccelerationService
{
    // https://learn.microsoft.com/windows/win32/api/dxva2api/nf-dxva2api-idirectxvideoaccelerationservice-createsurface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateSurface(uint Width, uint Height, uint BackBuffers, D3DFORMAT Format, D3DPOOL Pool, uint Usage, uint DxvaType, out IDirect3DSurface9 ppSurface, nint /* optional HANDLE* */ pSharedHandle);
}
