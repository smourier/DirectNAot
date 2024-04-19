namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KS_TVTUNER_CHANGE_INFO
{
    public uint dwFlags;
    public uint dwCountryCode;
    public uint dwAnalogVideoStandard;
    public uint dwChannel;
}
