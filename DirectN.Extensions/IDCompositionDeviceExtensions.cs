namespace DirectN.Extensions;

[SupportedOSPlatform("windows8.0")]
public static class IDCompositionDeviceExtensions
{
    public static void Commit(this IComObject<IDCompositionDevice> device) => Commit(device?.Object!);
    public static void Commit(this IDCompositionDevice device)
    {
        ArgumentNullException.ThrowIfNull(device);
        device.Commit().ThrowOnError();
    }

    public static bool CheckDeviceState(this IComObject<IDCompositionDevice> device) => CheckDeviceState(device?.Object!);
    public static bool CheckDeviceState(this IDCompositionDevice device)
    {
        ArgumentNullException.ThrowIfNull(device);
        device.CheckDeviceState(out var valid).ThrowOnError();
        return valid;
    }

    public static IComObject<IDCompositionTarget> CreateTargetForHwnd(this IComObject<IDCompositionDevice> device, HWND hwnd, bool topmost = true) => CreateTargetForHwnd(device?.Object!, hwnd, topmost);
    public static IComObject<IDCompositionTarget> CreateTargetForHwnd(this IDCompositionDevice device, HWND hwnd, bool topmost = true)
    {
        ArgumentNullException.ThrowIfNull(device);
        device.CreateTargetForHwnd(hwnd, topmost, out var target).ThrowOnError();
        return new ComObject<IDCompositionTarget>(target);
    }

    public static IComObject<IDCompositionVisual> CreateVisual(this IComObject<IDCompositionDevice> device) => CreateVisual(device?.Object!);
    public static IComObject<IDCompositionVisual> CreateVisual(this IDCompositionDevice device)
    {
        ArgumentNullException.ThrowIfNull(device);
        device.CreateVisual(out var visual).ThrowOnError();
        return new ComObject<IDCompositionVisual>(visual);
    }

    public static IComObject<IDCompositionSurface> CreateSurface(this IComObject<IDCompositionDevice> device, uint width, uint height, DXGI_FORMAT pixelFormat = DXGI_FORMAT.DXGI_FORMAT_B8G8R8A8_UNORM, DXGI_ALPHA_MODE alphaMode = DXGI_ALPHA_MODE.DXGI_ALPHA_MODE_PREMULTIPLIED) => CreateSurface(device?.Object!, width, height, pixelFormat, alphaMode);
    public static IComObject<IDCompositionSurface> CreateSurface(this IDCompositionDevice device, uint width, uint height, DXGI_FORMAT pixelFormat = DXGI_FORMAT.DXGI_FORMAT_B8G8R8A8_UNORM, DXGI_ALPHA_MODE alphaMode = DXGI_ALPHA_MODE.DXGI_ALPHA_MODE_PREMULTIPLIED)
    {
        ArgumentNullException.ThrowIfNull(device);
        device.CreateSurface(width, height, pixelFormat, alphaMode, out var surface).ThrowOnError();
        return new ComObject<IDCompositionSurface>(surface);
    }

    public static IComObject<IDCompositionVirtualSurface> CreateVirtualSurface(this IComObject<IDCompositionDevice> device, uint initialWidth, uint initialHeight, DXGI_FORMAT pixelFormat = DXGI_FORMAT.DXGI_FORMAT_B8G8R8A8_UNORM, DXGI_ALPHA_MODE alphaMode = DXGI_ALPHA_MODE.DXGI_ALPHA_MODE_PREMULTIPLIED) => CreateVirtualSurface(device?.Object!, initialWidth, initialHeight, pixelFormat, alphaMode);
    public static IComObject<IDCompositionVirtualSurface> CreateVirtualSurface(this IDCompositionDevice device, uint initialWidth, uint initialHeight, DXGI_FORMAT pixelFormat = DXGI_FORMAT.DXGI_FORMAT_B8G8R8A8_UNORM, DXGI_ALPHA_MODE alphaMode = DXGI_ALPHA_MODE.DXGI_ALPHA_MODE_PREMULTIPLIED)
    {
        ArgumentNullException.ThrowIfNull(device);
        device.CreateVirtualSurface(initialWidth, initialHeight, pixelFormat, alphaMode, out var surface).ThrowOnError();
        return new ComObject<IDCompositionVirtualSurface>(surface);
    }
}
