namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSRTAUDIO_HWREGISTER32
{
    public uint Register;
    public uint Width;
    public ulong Numerator;
    public ulong Denominator;
    public uint Accuracy;
}
