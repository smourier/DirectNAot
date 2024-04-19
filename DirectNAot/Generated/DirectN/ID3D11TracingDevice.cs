namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11sdklayers/nn-d3d11sdklayers-id3d11tracingdevice
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("1911c771-1587-413e-a7e0-fb26c3de0268")]
public partial interface ID3D11TracingDevice
{
    // https://learn.microsoft.com/windows/win32/api/d3d11sdklayers/nf-d3d11sdklayers-id3d11tracingdevice-setshadertrackingoptionsbytype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetShaderTrackingOptionsByType(uint ResourceTypeFlags, uint Options);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11sdklayers/nf-d3d11sdklayers-id3d11tracingdevice-setshadertrackingoptions
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetShaderTrackingOptions(nint pShader, uint Options);
}
