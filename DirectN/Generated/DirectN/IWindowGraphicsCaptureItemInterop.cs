#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("38e4c48b-94e6-4c44-9cfa-968193316c0c")]
public partial interface IWindowGraphicsCaptureItemInterop
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetWindow(ref HWND window);
}
