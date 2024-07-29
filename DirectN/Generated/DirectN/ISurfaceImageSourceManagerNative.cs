#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/windows.ui.xaml.media.dxinterop/nn-windows-ui-xaml-media-dxinterop-isurfaceimagesourcemanagernative
[GeneratedComInterface, Guid("4c8798b7-1d88-4a0f-b59b-b93f600de8c8")]
public partial interface ISurfaceImageSourceManagerNative
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FlushAllSurfacesWithDevice(nint device);
}
