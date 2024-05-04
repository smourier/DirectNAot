#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/windows.ui.composition.interop/nn-windows-ui-composition-interop-icompositiongraphicsdeviceinterop
[GeneratedComInterface, Guid("a116ff71-f8bf-4c8a-9c98-70779a32a9c8")]
public partial interface ICompositionGraphicsDeviceInterop
{
    // https://learn.microsoft.com/windows/win32/api/windows.ui.composition.interop/nf-windows-ui-composition-interop-icompositiongraphicsdeviceinterop-getrenderingdevice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRenderingDevice(out nint value);
    
    // https://learn.microsoft.com/windows/win32/api/windows.ui.composition.interop/nf-windows-ui-composition-interop-icompositiongraphicsdeviceinterop-setrenderingdevice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRenderingDevice(nint value);
}
