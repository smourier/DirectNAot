namespace DirectN;

public static class IDXGISwapChainExtensions
{
    [SupportedOSPlatform("windows8.0")]
    public static DXGI_SWAP_CHAIN_DESC1 GetDesc1(this IComObject<IDXGISwapChain1> swapChain) => GetDesc1(swapChain?.Object!);

    [SupportedOSPlatform("windows8.0")]
    public static DXGI_SWAP_CHAIN_DESC1 GetDesc1(this IDXGISwapChain1 swapChain)
    {
        ArgumentNullException.ThrowIfNull(swapChain);
        swapChain.GetDesc1(out var value).ThrowOnError();
        return value;
    }

    public static DXGI_SWAP_CHAIN_DESC GetDesc(this IComObject<IDXGISwapChain> swapChain) => GetDesc(swapChain?.Object!);
    public static DXGI_SWAP_CHAIN_DESC GetDesc(this IDXGISwapChain swapChain)
    {
        ArgumentNullException.ThrowIfNull(swapChain);
        swapChain.GetDesc(out var value).ThrowOnError();
        return value;
    }

    [SupportedOSPlatform("windows8.0")]
    public static HWND GetHwnd(this IComObject<IDXGISwapChain1> swapChain) => GetHwnd(swapChain?.Object!);

    [SupportedOSPlatform("windows8.0")]
    public static HWND GetHwnd(this IDXGISwapChain1 swapChain)
    {
        ArgumentNullException.ThrowIfNull(swapChain);
        swapChain.GetHwnd(out var value).ThrowOnError();
        return value;
    }

    [SupportedOSPlatform("windows8.0")]
    public static DXGI_SWAP_CHAIN_FULLSCREEN_DESC GetFullscreenDesc(this IComObject<IDXGISwapChain1> swapChain) => GetFullscreenDesc(swapChain?.Object!);

    [SupportedOSPlatform("windows8.0")]
    public static DXGI_SWAP_CHAIN_FULLSCREEN_DESC GetFullscreenDesc(this IDXGISwapChain1 swapChain)
    {
        ArgumentNullException.ThrowIfNull(swapChain);
        swapChain.GetFullscreenDesc(out var value).ThrowOnError();
        return value;
    }

    [SupportedOSPlatform("windows8.0")]
    public static IComObject<IDXGIOutput> GetRestrictToOutput(this IComObject<IDXGISwapChain1> swapChain) => GetRestrictToOutput(swapChain?.Object!);

    [SupportedOSPlatform("windows8.0")]
    public static IComObject<IDXGIOutput> GetRestrictToOutput(this IDXGISwapChain1 swapChain)
    {
        ArgumentNullException.ThrowIfNull(swapChain);
        swapChain.GetRestrictToOutput(out var value).ThrowOnError();
        return new ComObject<IDXGIOutput>(value);
    }

    [SupportedOSPlatform("windows8.0")]
    public static DXGI_MODE_ROTATION GetRotation(this IComObject<IDXGISwapChain1> swapChain) => GetRotation(swapChain?.Object!);

    [SupportedOSPlatform("windows8.0")]
    public static DXGI_MODE_ROTATION GetRotation(this IDXGISwapChain1 swapChain)
    {
        ArgumentNullException.ThrowIfNull(swapChain);
        swapChain.GetRotation(out var value).ThrowOnError();
        return value;
    }

    [SupportedOSPlatform("windows8.0")]
    public static void SetRotation(this IComObject<IDXGISwapChain1> swapChain, DXGI_MODE_ROTATION rotation) => SetRotation(swapChain?.Object!, rotation);

    [SupportedOSPlatform("windows8.0")]
    public static void SetRotation(this IDXGISwapChain1 swapChain, DXGI_MODE_ROTATION rotation)
    {
        ArgumentNullException.ThrowIfNull(swapChain);
        swapChain.SetRotation(rotation).ThrowOnError();
    }

    [SupportedOSPlatform("windows8.0")]
    public static DXGI_RGBA GetBackgroundColor(this IComObject<IDXGISwapChain1> swapChain) => GetBackgroundColor(swapChain?.Object!);

    [SupportedOSPlatform("windows8.0")]
    public static DXGI_RGBA GetBackgroundColor(this IDXGISwapChain1 swapChain)
    {
        ArgumentNullException.ThrowIfNull(swapChain);
        swapChain.GetBackgroundColor(out var value).ThrowOnError();
        return value;
    }

    [SupportedOSPlatform("windows8.0")]
    public static void SetBackgroundColor(this IComObject<IDXGISwapChain1> swapChain, DXGI_RGBA color) => SetBackgroundColor(swapChain?.Object!, color);

    [SupportedOSPlatform("windows8.0")]
    public static void SetBackgroundColor(this IDXGISwapChain1 swapChain, DXGI_RGBA color)
    {
        ArgumentNullException.ThrowIfNull(swapChain);
        swapChain.SetBackgroundColor(color).ThrowOnError();
    }

    public static IComObject<T> GetBuffer<T>(this IComObject<IDXGISwapChain> swapChain, uint index) => GetBuffer<T>(swapChain?.Object!, index);
    public static IComObject<T> GetBuffer<T>(this IDXGISwapChain swapChain, uint index)
    {
        ArgumentNullException.ThrowIfNull(swapChain);
        swapChain.GetBuffer(index, typeof(T).GUID, out var unk).ThrowOnError();
        return ComObject.FromPointer<T>(unk)!;
    }

    public static void ResizeBuffers(this IComObject<IDXGISwapChain> swapChain, uint bufferCount, uint width, uint height, DXGI_FORMAT newFormat, uint swapChainFlags) => ResizeBuffers(swapChain?.Object!, bufferCount, width, height, newFormat, swapChainFlags);
    public static void ResizeBuffers(this IDXGISwapChain swapChain, uint bufferCount, uint width, uint height, DXGI_FORMAT newFormat, uint swapChainFlags)
    {
        ArgumentNullException.ThrowIfNull(swapChain);
        swapChain.ResizeBuffers(bufferCount, width, height, newFormat, swapChainFlags).ThrowOnError();
    }

    public static void ResizeTarget(this IComObject<IDXGISwapChain> swapChain, DXGI_MODE_DESC newTargetParameters) => ResizeTarget(swapChain?.Object!, newTargetParameters);
    public static void ResizeTarget(this IDXGISwapChain swapChain, DXGI_MODE_DESC newTargetParameters)
    {
        ArgumentNullException.ThrowIfNull(swapChain);
        swapChain.ResizeTarget(newTargetParameters).ThrowOnError();
    }

    [SupportedOSPlatform("windows8.0")]
    public static void SetFullscreenState(this IComObject<IDXGISwapChain1> swapChain, bool state, IComObject<IDXGIOutput>? target = null) => SetFullscreenState(swapChain?.Object!, state, target?.Object!);

    [SupportedOSPlatform("windows8.0")]
    public static void SetFullscreenState(this IDXGISwapChain1 swapChain, bool state, IDXGIOutput? target = null)
    {
        ArgumentNullException.ThrowIfNull(swapChain);
        swapChain.SetFullscreenState(state, target).ThrowOnError();
    }

    [SupportedOSPlatform("windows8.0")]
    public static void SwitchFullscreenState(this IComObject<IDXGISwapChain1> swapChain) => SwitchFullscreenState(swapChain?.Object!);

    [SupportedOSPlatform("windows8.0")]
    public static void SwitchFullscreenState(this IDXGISwapChain1 swapChain) => swapChain.SetFullscreenState(!swapChain.IsFullScreenState(), null).ThrowOnError();

    public static void Present(this IComObject<IDXGISwapChain> swapChain, uint syncInterval, DXGI_PRESENT flags) => Present(swapChain?.Object!, syncInterval, flags);
    public static void Present(this IDXGISwapChain swapChain, uint syncInterval, DXGI_PRESENT flags)
    {
        ArgumentNullException.ThrowIfNull(swapChain);
        swapChain.Present(syncInterval, flags).ThrowOnError();
    }

    [SupportedOSPlatform("windows8.0")]
    public static void Present1(this IComObject<IDXGISwapChain1> swapChain, uint syncInterval, DXGI_PRESENT flags) => Present(swapChain?.Object!, syncInterval, flags);

    [SupportedOSPlatform("windows8.0")]
    public static void Present1(this IDXGISwapChain1 swapChain, uint syncInterval, DXGI_PRESENT flags, DXGI_PRESENT_PARAMETERS? parameters = null)
    {
        ArgumentNullException.ThrowIfNull(swapChain);
        if (parameters.HasValue)
        {
            swapChain.Present1(syncInterval, flags, parameters.Value).ThrowOnError();
        }
        else
        {
            swapChain.Present1(syncInterval, flags, Unsafe.NullRef<DXGI_PRESENT_PARAMETERS>()).ThrowOnError();
        }
    }

    public static bool IsFullScreenState(this IComObject<IDXGISwapChain> swapChain) => IsFullScreenState(swapChain?.Object!);
    public static bool IsFullScreenState(this IDXGISwapChain swapChain)
    {
        ArgumentNullException.ThrowIfNull(swapChain);
        unsafe
        {
            bool state;
            swapChain.GetFullscreenState((nint)(&state), 0).ThrowOnError();
            return state;
        }
    }
}
