#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/icm/ns-icm-colormatchsetupa
[StructLayout(LayoutKind.Sequential)]
public partial struct COLORMATCHSETUPA
{
    public uint dwSize;
    public uint dwVersion;
    public uint dwFlags;
    public HWND hwndOwner;
    public PSTR pSourceName;
    public PSTR pDisplayName;
    public PSTR pPrinterName;
    public uint dwRenderIntent;
    public uint dwProofingIntent;
    public PSTR pMonitorProfile;
    public uint ccMonitorProfile;
    public PSTR pPrinterProfile;
    public uint ccPrinterProfile;
    public PSTR pTargetProfile;
    public uint ccTargetProfile;
    public nint lpfnHook;
    public LPARAM lParam;
    public nint lpfnApplyCallback;
    public LPARAM lParamApplyCallback;
}
