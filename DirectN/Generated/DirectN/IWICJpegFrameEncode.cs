#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/nn-wincodec-iwicjpegframeencode
[SupportedOSPlatform("windows10.0.10240")]
[GeneratedComInterface, Guid("2f0c601f-d2c6-468c-abfa-49495d983ed1")]
public partial interface IWICJpegFrameEncode
{
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicjpegframeencode-getachuffmantable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAcHuffmanTable(uint scanIndex, uint tableIndex, out DXGI_JPEG_AC_HUFFMAN_TABLE pAcHuffmanTable);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicjpegframeencode-getdchuffmantable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDcHuffmanTable(uint scanIndex, uint tableIndex, out DXGI_JPEG_DC_HUFFMAN_TABLE pDcHuffmanTable);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicjpegframeencode-getquantizationtable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetQuantizationTable(uint scanIndex, uint tableIndex, out DXGI_JPEG_QUANTIZATION_TABLE pQuantizationTable);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicjpegframeencode-writescan
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT WriteScan(uint cbScanData, nint /* byte array */ pbScanData);
}
