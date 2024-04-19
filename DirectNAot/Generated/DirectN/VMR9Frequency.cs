namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vmr9/ns-vmr9-vmr9frequency
[StructLayout(LayoutKind.Sequential)]
public partial struct VMR9Frequency
{
    public uint dwNumerator;
    public uint dwDenominator;
}
