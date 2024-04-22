namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-displayconfig_sdr_white_level
[StructLayout(LayoutKind.Sequential)]
public partial struct DISPLAYCONFIG_SDR_WHITE_LEVEL
{
    public DISPLAYCONFIG_DEVICE_INFO_HEADER header;
    public uint SDRWhiteLevel;
}
