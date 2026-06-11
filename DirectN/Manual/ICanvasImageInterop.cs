namespace DirectN;

[GeneratedComInterface, Guid("E042D1F7-F9AD-4479-A713-67627EA31863")]
public partial interface ICanvasImageInterop
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDevice(out nint device, out WIN2D_GET_DEVICE_ASSOCIATION_TYPE type);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetD2DImage(
        nint device, 
        [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1DeviceContext>))] ID2D1DeviceContext deviceContext,
        WIN2D_GET_D2D_IMAGE_FLAGS flags,
        float targetDpi,
        nint realizeDpi,
        [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1Image>))] out ID2D1Image ppImage);
}
