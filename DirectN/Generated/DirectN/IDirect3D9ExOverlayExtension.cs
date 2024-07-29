#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d9/nn-d3d9-idirect3d9exoverlayextension
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("187aeb13-aaf5-4c59-876d-e059088c0df8")]
public partial interface IDirect3D9ExOverlayExtension
{
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3d9exoverlayextension-checkdeviceoverlaytype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CheckDeviceOverlayType(uint Adapter, D3DDEVTYPE DevType, uint OverlayWidth, uint OverlayHeight, D3DFORMAT OverlayFormat, ref D3DDISPLAYMODEEX pDisplayMode, D3DDISPLAYROTATION DisplayRotation, ref D3DOVERLAYCAPS pOverlayCaps);
}
