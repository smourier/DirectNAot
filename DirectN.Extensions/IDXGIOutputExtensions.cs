namespace DirectN;

[SupportedOSPlatform("windows6.1")]
public static class IDXGIOutputExtensions
{
    public static DXGI_OUTPUT_DESC GetDesc(this IComObject<IDXGIOutput> output) => GetDesc(output?.Object!);
    public static DXGI_OUTPUT_DESC GetDesc(this IDXGIOutput output)
    {
        ArgumentNullException.ThrowIfNull(output);
        output.GetDesc(out var desc).ThrowOnError();
        return desc;
    }

    public static DXGI_GAMMA_CONTROL_CAPABILITIES? GetGammaControlCapabilities(this IComObject<IDXGIOutput> output) => GetGammaControlCapabilities(output?.Object!);
    public static DXGI_GAMMA_CONTROL_CAPABILITIES? GetGammaControlCapabilities(this IDXGIOutput output)
    {
        ArgumentNullException.ThrowIfNull(output);
        if (output.GetGammaControlCapabilities(out var desc).IsError)
            return null;

        return desc;
    }

    public static DXGI_GAMMA_CONTROL? GetGammaControl(this IComObject<IDXGIOutput> output) => GetGammaControl(output?.Object!);
    public static DXGI_GAMMA_CONTROL? GetGammaControl(this IDXGIOutput output)
    {
        ArgumentNullException.ThrowIfNull(output);
        if (output.GetGammaControl(out var control).IsError)
            return null;

        return control;
    }

    public static DXGI_FRAME_STATISTICS? GetFrameStatistics(this IComObject<IDXGIOutput> output) => GetFrameStatistics(output?.Object!);
    public static DXGI_FRAME_STATISTICS? GetFrameStatistics(this IDXGIOutput output)
    {
        ArgumentNullException.ThrowIfNull(output);
        if (output.GetFrameStatistics(out var stats).IsError)
            return null;

        return stats;
    }

    public static IReadOnlyList<DXGI_MODE_DESC> GetDisplayModeList(this IComObject<IDXGIOutput> output, DXGI_FORMAT format, DXGI_ENUM_MODES modes) => GetDisplayModeList(output?.Object!, format, modes);
    public static IReadOnlyList<DXGI_MODE_DESC> GetDisplayModeList(this IDXGIOutput output, DXGI_FORMAT format, DXGI_ENUM_MODES modes)
    {
        ArgumentNullException.ThrowIfNull(output);

        // DXGI_FORMAT_R16G16B16A16_FLOAT
        // DXGI_FORMAT_R10G10B10A2_UNORM
        // DXGI_FORMAT_R8G8B8A8_UNORM
        // DXGI_FORMAT_R8G8B8A8_UNORM_SRGB
        // DXGI_FORMAT_B8G8R8A8_UNORM
        // DXGI_FORMAT_R10G10B10_XR_BIAS_A2_UNORM
        // DXGI_FORMAT_B8G8R8A8_UNORM_SRGB

        var list = new List<DXGI_MODE_DESC>();
        uint num = 0;
        output.GetDisplayModeList(format, modes, ref num, 0);
        if (num > 0)
        {
            var array = new DXGI_MODE_DESC[num];
            output.GetDisplayModeList(format, modes, ref num, array.AsPointer());
            list.AddRange(array);
        }
        return list;
    }

    [SupportedOSPlatform("windows8.0")]
    public static IReadOnlyList<DXGI_MODE_DESC1> GetDisplayModeList1(this IComObject<IDXGIOutput1> output, DXGI_FORMAT format, DXGI_ENUM_MODES modes) => GetDisplayModeList1(output?.Object!, format, modes);

    [SupportedOSPlatform("windows8.0")]
    public static IReadOnlyList<DXGI_MODE_DESC1> GetDisplayModeList1(this IDXGIOutput1 output, DXGI_FORMAT format, DXGI_ENUM_MODES modes)
    {
        ArgumentNullException.ThrowIfNull(output);
        var list = new List<DXGI_MODE_DESC1>();
        uint num = 0;
        output.GetDisplayModeList(format, modes, ref num, 0);
        if (num > 0)
        {
            var array = new DXGI_MODE_DESC1[num];
            output.GetDisplayModeList1(format, modes, ref num, array.AsPointer());
            list.AddRange(array);
        }
        return list;
    }

    public static DXGI_MODE_DESC? FindClosestMatchingMode(this IComObject<IDXGIOutput> output, DXGI_MODE_DESC modeToMatch, object concernedDevice) => FindClosestMatchingMode(output?.Object!, modeToMatch, concernedDevice);
    public static DXGI_MODE_DESC? FindClosestMatchingMode(this IDXGIOutput output, DXGI_MODE_DESC modeToMatch, object concernedDevice)
    {
        ArgumentNullException.ThrowIfNull(output);
        return ComObject.WithComInstance<DXGI_MODE_DESC?>(concernedDevice, ptr =>
        {
            if (output.FindClosestMatchingMode(modeToMatch, out var closest, ptr).IsError)
                return null;

            return closest;
        });
    }

    [SupportedOSPlatform("windows8.0")]
    public static DXGI_MODE_DESC1? FindClosestMatchingMode1(this IComObject<IDXGIOutput1> output, DXGI_MODE_DESC1 modeToMatch, object concernedDevice) => FindClosestMatchingMode1(output?.Object!, modeToMatch, concernedDevice);

    [SupportedOSPlatform("windows8.0")]
    public static DXGI_MODE_DESC1? FindClosestMatchingMode1(this IDXGIOutput1 output, DXGI_MODE_DESC1 modeToMatch, object concernedDevice)
    {
        ArgumentNullException.ThrowIfNull(output);
        return ComObject.WithComInstance<DXGI_MODE_DESC1?>(concernedDevice, ptr =>
        {
            if (output.FindClosestMatchingMode1(modeToMatch, out var closest, ptr).IsError)
                return null;

            return closest;
        });
    }

    [SupportedOSPlatform("windows8.0")]
    public static IComObject<IDXGIOutputDuplication> DuplicateOutput(this IComObject<IDXGIOutput1> output, object device, bool throwOnError = true) => DuplicateOutput(output?.Object!, device, throwOnError);

    [SupportedOSPlatform("windows8.0")]
    public static IComObject<IDXGIOutputDuplication> DuplicateOutput(this IDXGIOutput1 output, object device, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(output);
        ArgumentNullException.ThrowIfNull(device);
        return ComObject.WithComInstance(device, ptr =>
        {
            output.DuplicateOutput(ptr, out var dup).ThrowOnError(throwOnError);
            return new ComObject<IDXGIOutputDuplication>(dup);
        });
    }

    private delegate int QueryInterfaceFn(nint pThis, ref Guid riid, ref nint ppInterface);

    [StructLayout(LayoutKind.Sequential)]
    private class IDXGIOutputDuplicationVTable
    {
        // IUnknown
        public nint QueryInterfacePtr;
    }
}
