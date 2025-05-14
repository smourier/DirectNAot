namespace DirectN.Extensions;

[SupportedOSPlatform("windows8.0")]
public static class ID2D1DeviceExtensions
{
    public static IComObject<ID2D1DeviceContext> CreateDeviceContext(this IComObject<ID2D1Device> device, D2D1_DEVICE_CONTEXT_OPTIONS options = 0) => CreateDeviceContext<ID2D1DeviceContext>(device?.Object!, options);
    public static IComObject<T> CreateDeviceContext<T>(this IComObject<ID2D1Device> device, D2D1_DEVICE_CONTEXT_OPTIONS options = 0) where T : ID2D1DeviceContext => CreateDeviceContext<T>(device?.Object!, options);
    public static IComObject<T> CreateDeviceContext<T>(this ID2D1Device device, D2D1_DEVICE_CONTEXT_OPTIONS options = 0) where T : ID2D1DeviceContext
    {
        ArgumentNullException.ThrowIfNull(device);
        device.CreateDeviceContext(options, out var dc).ThrowOnError();
        return new ComObject<T>((T)dc);
    }

    public static void ClearResources(this IComObject<ID2D1Device> device, uint millisecondsSinceUse) => ClearResources(device?.Object!, millisecondsSinceUse);
    public static void ClearResources(this ID2D1Device device, uint millisecondsSinceUse)
    {
        ArgumentNullException.ThrowIfNull(device);
        device.ClearResources(millisecondsSinceUse);
    }

    public static void SetMaximumTextureMemory(this IComObject<ID2D1Device> device, ulong maximumInBytes) => SetMaximumTextureMemory(device?.Object!, maximumInBytes);
    public static void SetMaximumTextureMemory(this ID2D1Device device, ulong maximumInBytes)
    {
        ArgumentNullException.ThrowIfNull(device);
        device.SetMaximumTextureMemory(maximumInBytes);
    }

    public static ulong GetMaximumTextureMemory(this IComObject<ID2D1Device> device) => GetMaximumTextureMemory(device?.Object!);
    public static ulong GetMaximumTextureMemory(this ID2D1Device device)
    {
        ArgumentNullException.ThrowIfNull(device);
        return device.GetMaximumTextureMemory();
    }

    public static IComObject<IDXGIDevice> GetDxgiDevice(this IComObject<ID2D1Device2> device) => GetDxgiDevice(device?.Object!);
    public static IComObject<IDXGIDevice> GetDxgiDevice(this ID2D1Device2 device)
    {
        ArgumentNullException.ThrowIfNull(device);
        device.GetDxgiDevice(out var dxgi).ThrowOnError();
        return new ComObject<IDXGIDevice>(dxgi);
    }

    public static IComObject<ID2D1PrintControl> CreatePrintControl(this IComObject<ID2D1Device> device, IComObject<IWICImagingFactory> wicFactory, IComObject<IPrintDocumentPackageTarget> documentTarget, D2D1_PRINT_CONTROL_PROPERTIES? printControlProperties = null) => CreatePrintControl(device?.Object!, wicFactory?.Object!, documentTarget?.Object!, printControlProperties);
    public static IComObject<ID2D1PrintControl> CreatePrintControl(this ID2D1Device device, IWICImagingFactory wicFactory, IPrintDocumentPackageTarget documentTarget, D2D1_PRINT_CONTROL_PROPERTIES? printControlProperties = null)
    {
        ArgumentNullException.ThrowIfNull(device);
        ArgumentNullException.ThrowIfNull(wicFactory);
        ArgumentNullException.ThrowIfNull(documentTarget);
        ID2D1PrintControl pc;
        if (printControlProperties == null)
        {
            device.CreatePrintControl(wicFactory, documentTarget, 0, out pc).ThrowOnError();
        }
        else
        {
            unsafe
            {
                var props = printControlProperties.Value;
                device.CreatePrintControl(wicFactory, documentTarget, (nint)Unsafe.AsPointer(ref props), out pc).ThrowOnError();
            }
        }
        return new ComObject<ID2D1PrintControl>(pc);
    }
}
