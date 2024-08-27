namespace DirectN.Extensions.Utilities;

public static class DisplayConfig
{
    [SupportedOSPlatform("windows6.1")]
    public static DISPLAYCONFIG_PATH_INFO[] Query(QUERY_DISPLAY_CONFIG_FLAGS flags = QUERY_DISPLAY_CONFIG_FLAGS.QDC_ONLY_ACTIVE_PATHS)
    {
        var err = Functions.GetDisplayConfigBufferSizes(flags, out var pathCount, out var modeCount);
        if (err != 0)
            throw new Win32Exception((int)err);

        err = Functions.QueryDisplayConfig(flags, ref pathCount, out var paths, ref modeCount, out _, 0);
        if (err != 0)
            throw new Win32Exception((int)err);

        return paths;
    }

    [SupportedOSPlatform("windows6.0.6000")]
    public unsafe static DISPLAYCONFIG_TARGET_DEVICE_NAME GetTargetName(DISPLAYCONFIG_PATH_INFO path)
    {
        var info = new DISPLAYCONFIG_TARGET_DEVICE_NAME();
        info.header.type = DISPLAYCONFIG_DEVICE_INFO_TYPE.DISPLAYCONFIG_DEVICE_INFO_GET_TARGET_NAME;
        info.header.size = (uint)sizeof(DISPLAYCONFIG_TARGET_DEVICE_NAME);
        info.header.adapterId = path.targetInfo.adapterId;
        info.header.id = path.targetInfo.id;
        DisplayConfigGetDeviceInfo(&info);
        return info;
    }

    [SupportedOSPlatform("windows6.0.6000")]
    public unsafe static DISPLAYCONFIG_SDR_WHITE_LEVEL GetSdrWhiteLevel(DISPLAYCONFIG_PATH_INFO path)
    {
        var info = new DISPLAYCONFIG_SDR_WHITE_LEVEL();
        info.header.type = DISPLAYCONFIG_DEVICE_INFO_TYPE.DISPLAYCONFIG_DEVICE_INFO_GET_SDR_WHITE_LEVEL;
        info.header.size = (uint)sizeof(DISPLAYCONFIG_SDR_WHITE_LEVEL);
        info.header.adapterId = path.targetInfo.adapterId;
        info.header.id = path.targetInfo.id;
        DisplayConfigGetDeviceInfo(&info);
        return info;
    }

    [SupportedOSPlatform("windows6.0.6000")]
    public unsafe static DISPLAYCONFIG_GET_MONITOR_SPECIALIZATION GetMonitorSpecialization(DISPLAYCONFIG_PATH_INFO path)
    {
        var info = new DISPLAYCONFIG_GET_MONITOR_SPECIALIZATION();
        info.header.type = DISPLAYCONFIG_DEVICE_INFO_TYPE.DISPLAYCONFIG_DEVICE_INFO_GET_MONITOR_SPECIALIZATION;
        info.header.size = (uint)sizeof(DISPLAYCONFIG_GET_MONITOR_SPECIALIZATION);
        info.header.adapterId = path.targetInfo.adapterId;
        info.header.id = path.targetInfo.id;
        DisplayConfigGetDeviceInfo(&info);
        return info;
    }

    [SupportedOSPlatform("windows6.0.6000")]
    public unsafe static DISPLAYCONFIG_SOURCE_DEVICE_NAME GetSourceName(DISPLAYCONFIG_PATH_INFO path)
    {
        var info = new DISPLAYCONFIG_SOURCE_DEVICE_NAME();
        info.header.type = DISPLAYCONFIG_DEVICE_INFO_TYPE.DISPLAYCONFIG_DEVICE_INFO_GET_SOURCE_NAME;
        info.header.size = (uint)sizeof(DISPLAYCONFIG_SOURCE_DEVICE_NAME);
        info.header.adapterId = path.sourceInfo.adapterId;
        info.header.id = path.sourceInfo.id;
        DisplayConfigGetDeviceInfo(&info);
        return info;
    }

    [SupportedOSPlatform("windows6.0.6000")]
    public unsafe static DISPLAYCONFIG_GET_ADVANCED_COLOR_INFO GetAdvancedColorInfo(DISPLAYCONFIG_PATH_INFO path)
    {
        var info = new DISPLAYCONFIG_GET_ADVANCED_COLOR_INFO();
        info.header.type = DISPLAYCONFIG_DEVICE_INFO_TYPE.DISPLAYCONFIG_DEVICE_INFO_GET_ADVANCED_COLOR_INFO;
        info.header.size = (uint)sizeof(DISPLAYCONFIG_GET_ADVANCED_COLOR_INFO);
        info.header.adapterId = path.sourceInfo.adapterId;
        info.header.id = path.targetInfo.id;
        DisplayConfigGetDeviceInfo(&info);
        return info;
    }

    [SupportedOSPlatform("windows6.0.6000")]
    public unsafe static string? GetGdiDeviceName(int adapterIdHighPart, uint adapterIdLowPart, uint sourceId, bool throwOnError = true)
    {
        var info = new DISPLAYCONFIG_SOURCE_DEVICE_NAME();
        info.header.type = DISPLAYCONFIG_DEVICE_INFO_TYPE.DISPLAYCONFIG_DEVICE_INFO_GET_SOURCE_NAME;
        info.header.size = (uint)sizeof(DISPLAYCONFIG_SOURCE_DEVICE_NAME);
        info.header.adapterId.HighPart = adapterIdHighPart;
        info.header.adapterId.LowPart = adapterIdLowPart;
        info.header.id = sourceId;
        var err = DisplayConfigGetDeviceInfo(&info, throwOnError);
        if (err != 0)
            return null;

        return info.viewGdiDeviceName.ToString();
    }

    [SupportedOSPlatform("windows6.1")]
    public static uint? GetSourceId(uint targetId, QUERY_DISPLAY_CONFIG_FLAGS flags = QUERY_DISPLAY_CONFIG_FLAGS.QDC_ONLY_ACTIVE_PATHS)
    {
        var err = Functions.GetDisplayConfigBufferSizes(flags, out var pathCount, out var modeCount);
        if (err != 0)
            throw new Win32Exception((int)err);

        err = Functions.QueryDisplayConfig(flags, ref pathCount, out var paths, ref modeCount, out var modes, 0);
        if (err != 0)
            throw new Win32Exception((int)err);

        var first = paths.FirstOrDefault(p => p.targetInfo.id == targetId);
        if (first.targetInfo.id == targetId)
            return first.sourceInfo.id;

        return null;
    }

    [SupportedOSPlatform("windows6.0.6000")]
    private static unsafe int DisplayConfigGetDeviceInfo(void* info, bool throwOnError = true)
    {
        var err = Functions.DisplayConfigGetDeviceInfo(ref Unsafe.AsRef<DISPLAYCONFIG_DEVICE_INFO_HEADER>(info));
        if (err != 0 && throwOnError)
            throw new Win32Exception(err);

        return err;
    }
}
