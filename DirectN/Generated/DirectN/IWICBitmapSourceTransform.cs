#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/nn-wincodec-iwicbitmapsourcetransform
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("3b16811b-6a43-4ec9-b713-3d5a0c13b940")]
public partial interface IWICBitmapSourceTransform
{
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmapsourcetransform-copypixels
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CopyPixels(in WICRect prc, uint uiWidth, uint uiHeight, in Guid pguidDstFormat, WICBitmapTransformOptions dstTransform, uint nStride, uint cbBufferSize, nint /* byte array */ pbBuffer);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmapsourcetransform-getclosestsize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetClosestSize(ref uint puiWidth, ref uint puiHeight);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmapsourcetransform-getclosestpixelformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetClosestPixelFormat(ref Guid pguidDstFormat);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmapsourcetransform-doessupporttransform
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DoesSupportTransform(WICBitmapTransformOptions dstTransform, out BOOL pfIsSupported);
}
