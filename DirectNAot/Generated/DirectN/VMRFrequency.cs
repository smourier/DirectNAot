namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ns-strmif-vmrfrequency
[StructLayout(LayoutKind.Sequential)]
public partial struct VMRFrequency
{
    public uint dwNumerator;
    public uint dwDenominator;
}
