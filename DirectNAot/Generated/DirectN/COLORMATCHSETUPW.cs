namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/icm/ns-icm-colormatchsetupw
[StructLayout(LayoutKind.Sequential)]
public partial struct COLORMATCHSETUPW
{
    public uint dwSize;
    public uint dwVersion;
    public uint dwFlags;
    public HWND hwndOwner;
    public PWSTR pSourceName;
    public PWSTR pDisplayName;
    public PWSTR pPrinterName;
    public uint dwRenderIntent;
    public uint dwProofingIntent;
    public PWSTR pMonitorProfile;
    public uint ccMonitorProfile;
    public PWSTR pPrinterProfile;
    public uint ccPrinterProfile;
    public PWSTR pTargetProfile;
    public uint ccTargetProfile;
    public nint lpfnHook;
    public LPARAM lParam;
    public nint lpfnApplyCallback;
    public LPARAM lParamApplyCallback;
}
