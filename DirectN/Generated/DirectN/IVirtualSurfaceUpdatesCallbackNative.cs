#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/windows.ui.xaml.media.dxinterop/nn-windows-ui-xaml-media-dxinterop-ivirtualsurfaceupdatescallbacknative
[GeneratedComInterface, Guid("dbf2e947-8e6c-4254-9eee-7738f71386c9")]
public partial interface IVirtualSurfaceUpdatesCallbackNative
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UpdatesNeeded();
}
