namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/nn-wincodec-iwicbitmapframedecode
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("3b16811b-6a43-4ec9-a813-3d930c13b940")]
public partial interface IWICBitmapFrameDecode : IWICBitmapSource
{
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmapframedecode-getmetadataqueryreader
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetMetadataQueryReader(out IWICMetadataQueryReader ppIMetadataQueryReader);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmapframedecode-getcolorcontexts
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetColorContexts(uint cCount, ref IWICColorContext ppIColorContexts, out uint pcActualCount);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmapframedecode-getthumbnail
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetThumbnail(out IWICBitmapSource ppIThumbnail);
}
