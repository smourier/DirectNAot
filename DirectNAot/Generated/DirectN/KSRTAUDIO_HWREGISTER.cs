#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSRTAUDIO_HWREGISTER
{
    public nint Register;
    public uint Width;
    public ulong Numerator;
    public ulong Denominator;
    public uint Accuracy;
}
