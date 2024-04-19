namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSTIME
{
    public long Time;
    public uint Numerator;
    public uint Denominator;
}
