namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/nn-wincodec-iwicpixelformatinfo
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("e8eda601-3d48-431a-ab44-69059be88bbe")]
public partial interface IWICPixelFormatInfo : IWICComponentInfo
{
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicpixelformatinfo-getformatguid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetFormatGUID(out Guid pFormat);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicpixelformatinfo-getcolorcontext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetColorContext(out IWICColorContext ppIColorContext);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicpixelformatinfo-getbitsperpixel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetBitsPerPixel(out uint puiBitsPerPixel);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicpixelformatinfo-getchannelcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetChannelCount(out uint puiChannelCount);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicpixelformatinfo-getchannelmask
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetChannelMask(uint uiChannelIndex, uint cbMaskBuffer, nint /* byte array */ pbMaskBuffer, out uint pcbActual);
}
