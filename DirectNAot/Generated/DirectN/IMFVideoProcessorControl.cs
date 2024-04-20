namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfvideoprocessorcontrol
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("a3f675d5-6119-4f7f-a100-1d8b280f0efb")]
public partial interface IMFVideoProcessorControl
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfvideoprocessorcontrol-setbordercolor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBorderColor(nint /* optional MFARGB */ pBorderColor);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfvideoprocessorcontrol-setsourcerectangle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSourceRectangle(nint /* optional FoundationRECT */ pSrcRect);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfvideoprocessorcontrol-setdestinationrectangle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDestinationRectangle(nint /* optional FoundationRECT */ pDstRect);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfvideoprocessorcontrol-setmirror
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetMirror(MF_VIDEO_PROCESSOR_MIRROR eMirror);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfvideoprocessorcontrol-setrotation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRotation(MF_VIDEO_PROCESSOR_ROTATION eRotation);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfvideoprocessorcontrol-setconstrictionsize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetConstrictionSize(nint /* optional FoundationSIZE */ pConstrictionSize);
}
