namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/icm/ns-icm-hificolor
[StructLayout(LayoutKind.Sequential)]
public partial struct HiFiCOLOR
{
    public InlineArrayByte8 channel;
}
