﻿namespace DirectN;

[SupportedOSPlatform("windows6.1")]
public static class DXGIFunctions
{
    private static readonly Lazy<bool> _debugLayerAvailable = new(GetDebugLayerAvailable, true);
    public static bool IsDebugLayerAvailable => _debugLayerAvailable.Value;

    private static bool GetDebugLayerAvailable()
    {
        try
        {
            Functions.DXGIGetDebugInterface(typeof(IDXGIDebug).GUID, out var debug);
            Marshal.ReleaseComObject(debug);
            return true;
        }
        catch (DllNotFoundException)
        {
            return false;
        }
    }

    [SupportedOSPlatform("windows8.1")]
    public static void DXGIReportLiveObjects(DXGI_DEBUG_RLO_FLAGS flags = DXGI_DEBUG_RLO_FLAGS.DXGI_DEBUG_RLO_ALL) => DXGIReportLiveObjects(Constants.DXGI_DEBUG_ALL, flags);

    [SupportedOSPlatform("windows8.0")]
    public static void DXGIReportLiveObjects(Guid apiid, DXGI_DEBUG_RLO_FLAGS flags = DXGI_DEBUG_RLO_FLAGS.DXGI_DEBUG_RLO_ALL)
    {
        if (!IsDebugLayerAvailable)
            return;

        Functions.DXGIGetDebugInterface(typeof(IDXGIDebug).GUID, out var unk);
        if (unk == 0)
            return;

        using var dbg = ComObject.FromPointer<IDXGIDebug>(unk)!;
        dbg.Object.ReportLiveObjects(apiid, flags);
    }

    [SupportedOSPlatform("windows8.1")]
    public static IComObject<IDXGIDebug>? DXGIGetDebugInterface() => DXGIGetDebugInterface<IDXGIDebug>();
    public static IComObject<T>? DXGIGetDebugInterface<T>()
    {
        Functions.DXGIGetDebugInterface(typeof(T).GUID, out var unk);
        if (unk == 0)
            return null;

        return ComObject.FromPointer<T>(unk)!;
    }

    [SupportedOSPlatform("windows8.1")]
    public static IComObject<IDXGIDebug1>? DXGIGetDebugInterface1() => DXGIGetDebugInterface1<IDXGIDebug1>();
    public static IComObject<T>? DXGIGetDebugInterface1<T>()
    {
        Functions.DXGIGetDebugInterface(typeof(T).GUID, out var unk);
        if (unk == 0)
            return null;

        return ComObject.FromPointer<T>(unk)!;
    }

    [SupportedOSPlatform("windows8.1")]
    public static IComObject<IDXGIFactory2> CreateDXGIFactory2(DXGI_CREATE_FACTORY_FLAGS flags = 0) => CreateDXGIFactory2<IDXGIFactory2>(flags);

    [SupportedOSPlatform("windows8.1")]
    public static IComObject<T> CreateDXGIFactory2<T>(DXGI_CREATE_FACTORY_FLAGS flags = 0) where T : IDXGIFactory2
    {
        Functions.CreateDXGIFactory2(flags, typeof(T).GUID, out var unk).ThrowOnError();
        return ComObject.FromPointer<T>(unk)!;
    }

    public static IComObject<IDXGIFactory1> CreateDXGIFactory1() => CreateDXGIFactory1<IDXGIFactory1>();
    public static IComObject<T> CreateDXGIFactory1<T>() where T : IDXGIFactory1
    {
        Functions.CreateDXGIFactory1(typeof(T).GUID, out var unk).ThrowOnError();
        return ComObject.FromPointer<T>(unk)!;
    }
}
