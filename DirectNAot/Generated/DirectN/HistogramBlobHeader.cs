namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfapi/ns-mfapi-histogramblobheader
[StructLayout(LayoutKind.Sequential)]
public partial struct HistogramBlobHeader
{
    public uint Size;
    public uint Histograms;
}
