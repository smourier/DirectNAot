#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/ns-wincodec-wicjpegframeheader
public partial struct WICJpegFrameHeader
{
    public uint Width;
    public uint Height;
    public WICJpegTransferMatrix TransferMatrix;
    public WICJpegScanType ScanType;
    public uint cComponents;
    public uint ComponentIdentifiers;
    public uint SampleFactors;
    public uint QuantizationTableIndices;
}
