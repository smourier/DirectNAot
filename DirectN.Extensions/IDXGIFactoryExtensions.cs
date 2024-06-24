namespace DirectN;

public static class IDXGIFactoryExtensions
{
    [SupportedOSPlatform("windows6.1")]
    public static IEnumerable<IComObject<IDXGIAdapter>> EnumAdapters(this IComObject<IDXGIFactory1> factory) => EnumAdapters<IDXGIAdapter>(factory?.Object!);
    public static IEnumerable<IComObject<T>> EnumAdapters<T>(this IComObject<IDXGIFactory> factory) where T : IDXGIAdapter => EnumAdapters<T>(factory?.Object!);
    public static IEnumerable<IComObject<T>> EnumAdapters<T>(this IDXGIFactory factory) where T : IDXGIAdapter
    {
        ArgumentNullException.ThrowIfNull(factory);
        uint i = 0;
        do
        {
            if (factory.EnumAdapters(i++, out var adapter).IsError)
                yield break;

            yield return new ComObject<T>((T)adapter);
        }
        while (true);
    }

    [SupportedOSPlatform("windows6.1")]
    public static IEnumerable<IComObject<IDXGIAdapter1>> EnumAdapters1(this IComObject<IDXGIFactory1> factory) => EnumAdapters1<IDXGIAdapter1>(factory?.Object!);

    [SupportedOSPlatform("windows6.1")]
    public static IEnumerable<IComObject<T>> EnumAdapters1<T>(this IComObject<IDXGIFactory1> factory) where T : IDXGIAdapter1 => EnumAdapters1<T>(factory?.Object!);

    [SupportedOSPlatform("windows6.1")]
    public static IEnumerable<IComObject<T>> EnumAdapters1<T>(this IDXGIFactory1 factory) where T : IDXGIAdapter1
    {
        ArgumentNullException.ThrowIfNull(factory);
        uint i = 0;
        do
        {
            if (factory.EnumAdapters1(i++, out var adapter).IsError)
                yield break;

            yield return new ComObject<T>((T)adapter);
        }
        while (true);
    }


    [SupportedOSPlatform("windows6.1")]
    public static IComObject<IDXGIAdapter1>? GetAdapter1(this IComObject<IDXGIFactory1> factory, uint index) => GetAdapter1<IDXGIAdapter1>(factory?.Object!, index);

    [SupportedOSPlatform("windows6.1")]
    public static IComObject<T>? GetAdapter1<T>(this IComObject<IDXGIFactory1> factory, uint index) where T : IDXGIAdapter1 => GetAdapter1<T>(factory?.Object!, index);

    [SupportedOSPlatform("windows6.1")]
    public static IComObject<T>? GetAdapter1<T>(this IDXGIFactory1 factory, uint index) where T : IDXGIAdapter1
    {
        ArgumentNullException.ThrowIfNull(factory);
        uint i = 0;
        do
        {
            if (factory.EnumAdapters(i, out var adapter).IsError)
                return null;

            if (i == index)
                return new ComObject<T>((T)adapter);

            i++;
        }
        while (true);
    }

    [SupportedOSPlatform("windows8.0")]
    public static IComObject<T> CreateSwapChainForHwnd<T>(this IComObject<IDXGIFactory2> factory,
        IDXGIDevice1 device,
        HWND hwnd,
        DXGI_SWAP_CHAIN_DESC1 desc,
        DXGI_SWAP_CHAIN_FULLSCREEN_DESC? fullScreenDesc = null,
        IComObject<IDXGIOutput1>? restrictToOutput = null) where T : IDXGISwapChain1 => CreateSwapChainForHwnd<T>(factory?.Object!, device, hwnd, desc, fullScreenDesc, restrictToOutput?.Object!);

    [SupportedOSPlatform("windows8.0")]
    public static IComObject<T> CreateSwapChainForHwnd<T>(this IComObject<IDXGIFactory2> factory,
        ID3D11Device device,
        HWND hwnd,
        DXGI_SWAP_CHAIN_DESC1 desc,
        DXGI_SWAP_CHAIN_FULLSCREEN_DESC? fullScreenDesc = null,
        IComObject<IDXGIOutput1>? restrictToOutput = null) where T : IDXGISwapChain1 => CreateSwapChainForHwnd<T>(factory?.Object!, device, hwnd, desc, fullScreenDesc, restrictToOutput?.Object!);

    [SupportedOSPlatform("windows8.0")]
    public static IComObject<T> CreateSwapChainForHwnd<T>(this IComObject<IDXGIFactory2> factory,
        IComObject<IDXGIDevice1> device,
        HWND hwnd,
        DXGI_SWAP_CHAIN_DESC1 desc,
        DXGI_SWAP_CHAIN_FULLSCREEN_DESC? fullScreenDesc = null,
        IComObject<IDXGIOutput1>? restrictToOutput = null) where T : IDXGISwapChain1 => CreateSwapChainForHwnd<T>(factory?.Object!, device?.Object!, hwnd, desc, fullScreenDesc, restrictToOutput?.Object!);

    [SupportedOSPlatform("windows8.0")]
    public static IComObject<T> CreateSwapChainForHwnd<T>(this IComObject<IDXGIFactory2> factory,
        IComObject<ID3D11Device> device,
        HWND hwnd,
        DXGI_SWAP_CHAIN_DESC1 desc,
        DXGI_SWAP_CHAIN_FULLSCREEN_DESC? fullScreenDesc = null,
        IComObject<IDXGIOutput1>? restrictToOutput = null) where T : IDXGISwapChain1 => CreateSwapChainForHwnd<T>(factory?.Object!, device?.Object!, hwnd, desc, fullScreenDesc, restrictToOutput?.Object!);

    [SupportedOSPlatform("windows8.0")]
    public static IComObject<T> CreateSwapChainForHwnd<T>(this IComObject<IDXGIFactory2> factory,
        IComObject<ID3D12CommandQueue> device,
        HWND hwnd,
        DXGI_SWAP_CHAIN_DESC1 desc,
        DXGI_SWAP_CHAIN_FULLSCREEN_DESC? fullScreenDesc = null,
        IComObject<IDXGIOutput1>? restrictToOutput = null) where T : IDXGISwapChain1 => CreateSwapChainForHwnd<T>(factory?.Object!, device?.Object!, hwnd, desc, fullScreenDesc, restrictToOutput?.Object!);

    [SupportedOSPlatform("windows8.0")]
    public static IComObject<T> CreateSwapChainForHwnd<T>(this IDXGIFactory2 factory,
        object device,
        HWND hwnd,
        DXGI_SWAP_CHAIN_DESC1 desc,
        DXGI_SWAP_CHAIN_FULLSCREEN_DESC? fullScreenDesc = null,
        IDXGIOutput1? restrictToOutput = null) where T : IDXGISwapChain1
    {
        ArgumentNullException.ThrowIfNull(factory);
        ArgumentNullException.ThrowIfNull(device);
        return ComObject.WithComInstance(device, unk =>
        {
            factory.CreateSwapChainForHwnd(unk, hwnd, desc, fullScreenDesc.CopyToPointer(), restrictToOutput, out var swapChain).ThrowOnError();
            return new ComObject<T>((T)swapChain);
        });
    }

    [SupportedOSPlatform("windows8.0")]
    public static IComObject<T> CreateSwapChainForComposition<T>(this IComObject<IDXGIFactory2> factory,
        IComObject<IDXGIDevice1> device,
        DXGI_SWAP_CHAIN_DESC1 desc,
        IComObject<IDXGIOutput1>? restrictToOutput = null) where T : IDXGISwapChain1 => CreateSwapChainForComposition<T>(factory?.Object!, device?.Object!, desc, restrictToOutput?.Object!);

    [SupportedOSPlatform("windows8.0")]
    public static IComObject<IDXGISwapChain1> CreateSwapChainForComposition(this IComObject<IDXGIFactory2> factory,
        IComObject<IDXGIDevice1> device,
        DXGI_SWAP_CHAIN_DESC1 desc,
        IComObject<IDXGIOutput1>? restrictToOutput = null) => CreateSwapChainForComposition<IDXGISwapChain1>(factory?.Object!, device?.Object!, desc, restrictToOutput?.Object!);

    [SupportedOSPlatform("windows8.0")]
    public static IComObject<T> CreateSwapChainForComposition<T>(this IDXGIFactory2 factory,
        IDXGIDevice1 device,
        DXGI_SWAP_CHAIN_DESC1 desc,
        IDXGIOutput1? restrictToOutput = null) where T : IDXGISwapChain1
    {
        ArgumentNullException.ThrowIfNull(factory);
        ArgumentNullException.ThrowIfNull(device);
        return ComObject.WithComInstance(device, unk =>
        {
            factory.CreateSwapChainForComposition(unk, desc, restrictToOutput, out var swapChain).ThrowOnError();
            return new ComObject<T>((T)swapChain);
        });
    }

    [SupportedOSPlatform("windows10.0.17134")]
    public static IComObject<IDXGIAdapter1>? EnumAdapterByGpuPreference(this IComObject<IDXGIFactory6> factory, uint index, DXGI_GPU_PREFERENCE preference) => EnumAdapterByGpuPreference<IDXGIAdapter1>(factory?.Object!, index, preference);

    [SupportedOSPlatform("windows10.0.17134")]
    public static IComObject<IDXGIAdapter1>? EnumAdapterByGpuPreference(this IDXGIFactory6 factory, uint index, DXGI_GPU_PREFERENCE preference) => EnumAdapterByGpuPreference<IDXGIAdapter1>(factory, index, preference);

    [SupportedOSPlatform("windows10.0.17134")]
    public static IComObject<T>? EnumAdapterByGpuPreference<T>(this IComObject<IDXGIFactory6> factory, uint index, DXGI_GPU_PREFERENCE preference) where T : IDXGIAdapter => EnumAdapterByGpuPreference<T>(factory?.Object!, index, preference);

    [SupportedOSPlatform("windows10.0.17134")]
    public static IComObject<T>? EnumAdapterByGpuPreference<T>(this IDXGIFactory6 factory, uint index, DXGI_GPU_PREFERENCE preference) where T : IDXGIAdapter
    {
        ArgumentNullException.ThrowIfNull(factory);
        factory.EnumAdapterByGpuPreference(index, preference, typeof(T).GUID, out var unk);
        return unk == 0 ? null : ComObject.FromPointer<T>(unk);
    }

    [SupportedOSPlatform("windows6.1")]
    public static IComObject<IDXGIAdapter1>? GetHardwareAdapter(this IComObject<IDXGIFactory1> factory, DXGI_GPU_PREFERENCE preference = DXGI_GPU_PREFERENCE.DXGI_GPU_PREFERENCE_UNSPECIFIED) => GetHardwareAdapter(factory?.Object!, preference);

    [SupportedOSPlatform("windows6.1")]
    public static IComObject<IDXGIAdapter1>? GetHardwareAdapter(this IDXGIFactory1 factory, DXGI_GPU_PREFERENCE preference = DXGI_GPU_PREFERENCE.DXGI_GPU_PREFERENCE_UNSPECIFIED)
    {
        ArgumentNullException.ThrowIfNull(factory);
        var list = new List<IComObject<IDXGIAdapter1>>();
        IComObject<IDXGIAdapter1>? adapter = null;
        if (factory is IDXGIFactory6 fac)
        {
#pragma warning disable CA1416 // Validate platform compatibility
            uint index = 0;
            do
            {
                adapter = fac.EnumAdapterByGpuPreference(index++, preference);
                if (adapter == null)
                    break;

                list.Add(adapter);
                var desc = adapter.GetDesc1();
                var flags = (DXGI_ADAPTER_FLAG)desc.Flags;
                if (flags.HasFlag(DXGI_ADAPTER_FLAG.DXGI_ADAPTER_FLAG_SOFTWARE))
                    continue;

                var hr = D3D12Functions.D3D12CheckDeviceCreate(adapter, D3D_FEATURE_LEVEL.D3D_FEATURE_LEVEL_11_0);
                if (hr == Constants.E_INVALIDARG)
                    continue;

                hr.ThrowOnError();
            }
            while (true);
        }

        if (adapter == null)
        {
            foreach (var a in factory.EnumAdapters1<IDXGIAdapter1>())
            {
                list.Add(a);
                var desc = a.GetDesc1();
                var flags = (DXGI_ADAPTER_FLAG)desc.Flags;
                if (flags.HasFlag(DXGI_ADAPTER_FLAG.DXGI_ADAPTER_FLAG_SOFTWARE))
                    continue;

                var hr = D3D12Functions.D3D12CheckDeviceCreate(a, D3D_FEATURE_LEVEL.D3D_FEATURE_LEVEL_11_0);
                if (hr.IsSuccess)
                {
                    adapter = a;
                    break;
                }
                if (hr == Constants.E_INVALIDARG)
                    continue;

                hr.ThrowOnError();
            }
        }
#pragma warning restore CA1416 // Validate platform compatibility
        foreach (var ad in list)
        {
            if (ad == adapter)
                continue;

            ad.Dispose();
        }

        return adapter;
    }
}
