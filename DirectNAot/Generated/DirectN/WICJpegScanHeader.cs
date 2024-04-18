namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/ns-wincodec-wicjpegscanheader
[StructLayout(LayoutKind.Sequential)]
public partial struct WICJpegScanHeader
{
    public uint cComponents;
    public uint RestartInterval;
    public uint ComponentSelectors;
    public uint HuffmanTableIndices;
    public byte StartSpectralSelection;
    public byte EndSpectralSelection;
    public byte SuccessiveApproximationHigh;
    public byte SuccessiveApproximationLow;
}
