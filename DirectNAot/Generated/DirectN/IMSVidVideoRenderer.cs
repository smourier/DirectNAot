﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/segment/nn-segment-imsvidvideorenderer
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("37b03540-a4c8-11d2-b634-00c04f79498e")]
public partial interface IMSVidVideoRenderer : IMSVidOutputDevice
{
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidvideorenderer-get_customcompositorclass
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_CustomCompositorClass(out BSTR CompositorCLSID);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidvideorenderer-put_customcompositorclass
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_CustomCompositorClass(BSTR CompositorCLSID);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidvideorenderer-get__customcompositorclass
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get__CustomCompositorClass(out Guid CompositorCLSID);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidvideorenderer-put__customcompositorclass
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put__CustomCompositorClass(in Guid CompositorCLSID);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidvideorenderer-get__customcompositor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get__CustomCompositor(out IVMRImageCompositor Compositor);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidvideorenderer-put__customcompositor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put__CustomCompositor(IVMRImageCompositor Compositor);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidvideorenderer-get_mixerbitmap
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_MixerBitmap(out IPictureDisp MixerPictureDisp);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidvideorenderer-get__mixerbitmap
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get__MixerBitmap(out IVMRMixerBitmap MixerPicture);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidvideorenderer-put_mixerbitmap
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_MixerBitmap(IPictureDisp MixerPictureDisp);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidvideorenderer-put__mixerbitmap
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put__MixerBitmap(in VMRALPHABITMAP MixerPicture);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidvideorenderer-get_mixerbitmappositionrect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_MixerBitmapPositionRect(out IMSVidRect rDest);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidvideorenderer-put_mixerbitmappositionrect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_MixerBitmapPositionRect(IMSVidRect rDest);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidvideorenderer-get_mixerbitmapopacity
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_MixerBitmapOpacity(out int opacity);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidvideorenderer-put_mixerbitmapopacity
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_MixerBitmapOpacity(int opacity);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidvideorenderer-setupmixerbitmap
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetupMixerBitmap(IPictureDisp MixerPictureDisp, int Opacity, IMSVidRect rDest);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidvideorenderer-get_sourcesize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_SourceSize(out SourceSizeList CurrentSize);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidvideorenderer-put_sourcesize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_SourceSize(SourceSizeList NewSize);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidvideorenderer-get_overscan
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_OverScan(out int plPercent);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidvideorenderer-put_overscan
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_OverScan(int lPercent);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidvideorenderer-get_availablesourcerect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_AvailableSourceRect(out IMSVidRect pRect);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidvideorenderer-get_maxvidrect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_MaxVidRect(out IMSVidRect ppVidRect);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidvideorenderer-get_minvidrect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_MinVidRect(out IMSVidRect ppVidRect);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidvideorenderer-get_clippedsourcerect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ClippedSourceRect(out IMSVidRect pRect);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidvideorenderer-put_clippedsourcerect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_ClippedSourceRect(IMSVidRect pRect);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidvideorenderer-get_usingoverlay
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_UsingOverlay(out VARIANT_BOOL UseOverlayVal);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidvideorenderer-put_usingoverlay
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_UsingOverlay(VARIANT_BOOL UseOverlayVal);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidvideorenderer-capture
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Capture(out IPictureDisp currentImage);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidvideorenderer-get_framespersecond
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_FramesPerSecond(out int pVal);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidvideorenderer-get_decimateinput
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_DecimateInput(out VARIANT_BOOL pDeci);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidvideorenderer-put_decimateinput
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_DecimateInput(VARIANT_BOOL pDeci);
}
