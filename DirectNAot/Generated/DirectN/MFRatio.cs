namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfobjects/ns-mfobjects-mfratio
[StructLayout(LayoutKind.Sequential)]
public partial struct MFRatio
{
    public uint Numerator;
    public uint Denominator;
}
