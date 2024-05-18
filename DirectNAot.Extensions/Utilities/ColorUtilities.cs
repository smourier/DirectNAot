namespace DirectNAot.Extensions.Utilities;

public static partial class ColorUtilities
{
    private static readonly Lazy<ConcurrentDictionary<string, ImmersiveColor>> _immersiveColors = new(GetImmersiveColors, true);
    public static IReadOnlyDictionary<string, ImmersiveColor> ImmersiveColors => _immersiveColors.Value;

    public static D3DCOLORVALUE? GetColor(string name, D3DCOLORVALUE? defaultValue = null)
    {
        ArgumentNullException.ThrowIfNull(name);

        if (!_immersiveColors.Value.TryRemove(name, out var value))
            return defaultValue;

        return value.Color;
    }

    public static IEnumerable<Tuple<SYS_COLOR_INDEX, D3DCOLORVALUE>> SysColors
    {
        get
        {
            foreach (var color in Enum.GetValues<SYS_COLOR_INDEX>())
            {
                yield return new Tuple<SYS_COLOR_INDEX, D3DCOLORVALUE>(color, GetSysColor(color));
            }
        }
    }

    [SupportedOSPlatform("windows6.0.6000")]
    public static IEnumerable<Tuple<SYS_COLOR_INDEX, D3DCOLORVALUE>> GetThemeSysColors(HTHEME theme)
    {
        foreach (var color in Enum.GetValues<SYS_COLOR_INDEX>())
        {
            yield return new Tuple<SYS_COLOR_INDEX, D3DCOLORVALUE>(color, GetThemeSysColor(theme, color));
        }
    }

    public static D3DCOLORVALUE GetSysColor(SYS_COLOR_INDEX color) => D3DCOLORVALUE.FromCOLORREF(Functions.GetSysColor(color));
    [SupportedOSPlatform("windows6.0.6000")]
    public static D3DCOLORVALUE GetThemeSysColor(HTHEME theme, SYS_COLOR_INDEX color) => D3DCOLORVALUE.FromCOLORREF(Functions.GetThemeSysColor(theme, (int)color).Value);

    [SupportedOSPlatform("windows6.0.6000")]
    public static D3DCOLORVALUE GetThemeColor(string classList, int partId = 0, int stateId = 0, int propId = 0, D3DCOLORVALUE? defaultColor = null, HWND? hwnd = null)
    {
        ArgumentNullException.ThrowIfNull(classList);

        using var list = new Pwstr(classList);
        var theme = Functions.OpenThemeData(hwnd ?? HWND.Null, list);
        if (theme.Value == 0)
            return defaultColor ?? D3DCOLORVALUE.Black;

        try
        {
            var hr = Functions.GetThemeColor(theme, partId, stateId, propId, out var color);
            if (hr.IsError)
                return defaultColor ?? D3DCOLORVALUE.Black;

            return D3DCOLORVALUE.FromCOLORREF(color);
        }
        finally
        {
            Functions.CloseThemeData(theme);
        }
    }

    private static ConcurrentDictionary<string, ImmersiveColor> GetImmersiveColors()
    {
        var dic = new ConcurrentDictionary<string, ImmersiveColor>(StringComparer.OrdinalIgnoreCase);
        try
        {
            GetUserColorPreference(out var pref, false);
            var i = 0;
            do
            {
                var ptr = GetImmersiveColorNamedTypeByIndex(i);
                if (ptr == 0)
                    break;

                unsafe
                {
                    var nt = (IMMERSIVE_COLOR_NAMED_TYPES*)ptr;
                    var color = GetColorFromPreference(ref pref, nt->colorType, false, IMMERSIVE_HC_CACHE_MODE.IHCM_USE_CACHED_VALUE);
                    var type = Marshal.PtrToStringUni(nt->pszColorType)!;
                    var ic = new ImmersiveColor(type, nt->colorType)
                    {
                        Color = D3DCOLORVALUE.FromCOLORREF(color)
                    };
                    dic[ic.Name] = ic;
                    i++;
                }
            }
            while (true);
        }
        catch
        {
            // do nothing
        }
        return dic;
    }

    [LibraryImport("uxtheme", EntryPoint = "#100")]
    private static partial nint GetImmersiveColorNamedTypeByIndex(int index);

    [LibraryImport("uxtheme")]
    private static partial uint GetUserColorPreference(out IMMERSIVE_COLOR_PREFERENCE pcpPreference, [MarshalAs(UnmanagedType.U4)] bool fForceReload);

    [LibraryImport("uxtheme")]
    private static partial uint GetColorFromPreference(ref IMMERSIVE_COLOR_PREFERENCE cpcpPreference, int colorType, [MarshalAs(UnmanagedType.U4)] bool fNoHighContrast, IMMERSIVE_HC_CACHE_MODE mode);

    private enum IMMERSIVE_HC_CACHE_MODE
    {
        IHCM_USE_CACHED_VALUE = 0,
        IHCM_REFRESH = 1,
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    private struct IMMERSIVE_COLOR_NAMED_TYPES
    {
        public IntPtr pszColorType;
        public int colorType;
    }

    [StructLayout(LayoutKind.Sequential)]
    private struct IMMERSIVE_COLOR_PREFERENCE
    {
        public uint dwColorSetIndex;
        public uint crStartColor;
        public uint crAccentColor;
    }
}
