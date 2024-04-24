namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/nn-wincodec-iwicplanarbitmapframeencode
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("f928b7b8-2221-40c1-b72e-7e82f1974d1a")]
public partial interface IWICPlanarBitmapFrameEncode
{
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicplanarbitmapframeencode-writepixels
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT WritePixels(uint lineCount, [MarshalUsing(CountElementName = nameof(cPlanes))] in WICBitmapPlane[] pPlanes, uint cPlanes);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicplanarbitmapframeencode-writesource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT WriteSource([MarshalUsing(CountElementName = nameof(cPlanes))] in IWICBitmapSource[] ppPlanes, uint cPlanes, in WICRect prcSource);
}
