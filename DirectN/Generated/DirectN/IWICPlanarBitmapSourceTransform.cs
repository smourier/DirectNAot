#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/nn-wincodec-iwicplanarbitmapsourcetransform
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("3aff9cce-be95-4303-b927-e7d16ff4a613")]
public partial interface IWICPlanarBitmapSourceTransform
{
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicplanarbitmapsourcetransform-doessupporttransform
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DoesSupportTransform(ref uint puiWidth, ref uint puiHeight, WICBitmapTransformOptions dstTransform, WICPlanarOptions dstPlanarOptions, [In][MarshalUsing(CountElementName = nameof(cPlanes))] Guid[] pguidDstFormats, [In][Out][MarshalUsing(CountElementName = nameof(cPlanes))] WICBitmapPlaneDescription[] pPlaneDescriptions, uint cPlanes, out BOOL pfIsSupported);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicplanarbitmapsourcetransform-copypixels
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CopyPixels(in WICRect prcSource, uint uiWidth, uint uiHeight, WICBitmapTransformOptions dstTransform, WICPlanarOptions dstPlanarOptions, [In][MarshalUsing(CountElementName = nameof(cPlanes))] WICBitmapPlane[] pDstPlanes, uint cPlanes);
}
