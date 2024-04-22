namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/icm/ns-icm-generic3channel
[StructLayout(LayoutKind.Sequential)]
public partial struct GENERIC3CHANNEL
{
    public ushort ch1;
    public ushort ch2;
    public ushort ch3;
}
