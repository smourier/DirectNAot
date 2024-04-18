namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/nn-wincodec-iwicjpegframedecode
[SupportedOSPlatform("windows10.0.10240")]
[GeneratedComInterface, Guid("8939f66e-c46a-4c21-a9d1-98b327ce1679")]
public partial interface IWICJpegFrameDecode
{
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicjpegframedecode-doessupportindexing
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT DoesSupportIndexing([MarshalAs(UnmanagedType.U4)] out bool pfIndexingSupported);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicjpegframedecode-setindexing
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetIndexing(WICJpegIndexingOptions options, uint horizontalIntervalSize);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicjpegframedecode-clearindexing
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT ClearIndexing();
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicjpegframedecode-getachuffmantable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetAcHuffmanTable(uint scanIndex, uint tableIndex, out DXGI_JPEG_AC_HUFFMAN_TABLE pAcHuffmanTable);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicjpegframedecode-getdchuffmantable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetDcHuffmanTable(uint scanIndex, uint tableIndex, out DXGI_JPEG_DC_HUFFMAN_TABLE pDcHuffmanTable);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicjpegframedecode-getquantizationtable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetQuantizationTable(uint scanIndex, uint tableIndex, out DXGI_JPEG_QUANTIZATION_TABLE pQuantizationTable);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicjpegframedecode-getframeheader
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetFrameHeader(out WICJpegFrameHeader pFrameHeader);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicjpegframedecode-getscanheader
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetScanHeader(uint scanIndex, out WICJpegScanHeader pScanHeader);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicjpegframedecode-copyscan
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CopyScan(uint scanIndex, uint scanOffset, uint cbScanData, nint /* byte array */ pbScanData, out uint pcbScanDataActual);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CopyMinimalStream(uint streamOffset, uint cbStreamData, nint /* byte array */ pbStreamData, out uint pcbStreamDataActual);
}
