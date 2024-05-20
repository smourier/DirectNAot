namespace DirectN.Extensions.Utilities
{
    public class DisplayDevice(DISPLAY_DEVICEW device)
    {
        public string DeviceName { get; } = device.DeviceName.ToString();
        public string DeviceString { get; } = device.DeviceString.ToString();
        public DISPLAY_DEVICE_FLAGS StateFlags { get; } = (DISPLAY_DEVICE_FLAGS)device.StateFlags;
        public string DeviceID { get; } = device.DeviceID.ToString();
        public string DeviceKey { get; } = device.DeviceKey.ToString();

        public bool IsPrimary => StateFlags.HasFlag(DISPLAY_DEVICE_FLAGS.DISPLAY_DEVICE_PRIMARY_DEVICE);

        public string MonitorName
        {
            get
            {
                var dd = CreateDISPLAY_DEVICEW();
                using var name = new Pwstr(DeviceName);
                _ = Functions.EnumDisplayDevicesW(name, 0, ref dd, 0);
                return dd.DeviceString.ToString();
            }
        }

        public Monitor? Monitor
        {
            get
            {
                foreach (var monitor in Monitor.All)
                {
                    if (monitor.DeviceName.EqualsIgnoreCase(DeviceName))
                        return monitor;
                }
                return null;
            }
        }

        public override string ToString() => "Name=" + MonitorName + " (" + DeviceName + ") on " + DeviceString + ", Id=" + DeviceID + ", Key=" + DeviceKey + ", Flags=" + StateFlags;

        public static DisplayDevice? Primary => All.FirstOrDefault(d => d.StateFlags.HasFlag(DISPLAY_DEVICE_FLAGS.DISPLAY_DEVICE_PRIMARY_DEVICE));
        public static IEnumerable<DisplayDevice> Active => All.Where(d => d.StateFlags.HasFlag(DISPLAY_DEVICE_FLAGS.DISPLAY_DEVICE_ACTIVE));
        public static IEnumerable<DisplayDevice> All
        {
            get
            {
                var dd = CreateDISPLAY_DEVICEW();
                uint index = 0;
                do
                {
                    if (!Functions.EnumDisplayDevicesW(PWSTR.Null, index++, ref dd, 0))
                        break;

                    yield return new DisplayDevice(dd);
                }
                while (true);
            }
        }

        private unsafe static DISPLAY_DEVICEW CreateDISPLAY_DEVICEW() => new() { cb = (uint)sizeof(DISPLAY_DEVICEW) };

        public DEVMODEW CurrentSettings
        {
            get
            {
                var mode = new DEVMODEW();
                using var name = new Pwstr(DeviceName);
                Functions.EnumDisplaySettingsExW(name, ENUM_DISPLAY_SETTINGS_MODE.ENUM_CURRENT_SETTINGS, ref mode, 0);
                return mode;
            }
        }

        public DEVMODEW RegistrySettings
        {
            get
            {
                var mode = new DEVMODEW();
                using var name = new Pwstr(DeviceName);
                Functions.EnumDisplaySettingsExW(name, ENUM_DISPLAY_SETTINGS_MODE.ENUM_REGISTRY_SETTINGS, ref mode, 0);
                return mode;
            }
        }

        public IEnumerable<DEVMODEW> GetModes(ENUM_DISPLAY_SETTINGS_FLAGS flags = 0)
        {
            var i = 0;
            var mode = new DEVMODEW();
            using var name = new Pwstr(DeviceName);
            while (Functions.EnumDisplaySettingsExW(name, (ENUM_DISPLAY_SETTINGS_MODE)i++, ref mode, flags))
            {
                yield return mode;
            }
        }

    }
}
