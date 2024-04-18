namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct OEMUIPROCS
{
    public nint DrvGetDriverSetting;
    public nint DrvUpdateUISetting;
}
