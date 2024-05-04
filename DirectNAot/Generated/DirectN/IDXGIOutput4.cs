#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi1_4/nn-dxgi1_4-idxgioutput4
[SupportedOSPlatform("windows10.0.10240")]
[GeneratedComInterface, Guid("dc7dca35-2196-414d-9f53-617884032a60")]
public partial interface IDXGIOutput4 : IDXGIOutput3
{
    // https://learn.microsoft.com/windows/win32/api/dxgi1_4/nf-dxgi1_4-idxgioutput4-checkoverlaycolorspacesupport
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CheckOverlayColorSpaceSupport(DXGI_FORMAT Format, DXGI_COLOR_SPACE_TYPE ColorSpace, nint pConcernedDevice, out uint pFlags);
}
