#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfmediaengine/nn-mfmediaengine-imfmediaengineprotectedcontent
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("9f8021e8-9c8c-487e-bb5c-79aa4779938c")]
public partial interface IMFMediaEngineProtectedContent
{
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengineprotectedcontent-shareresources
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ShareResources(nint pUnkDeviceContext);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengineprotectedcontent-getrequiredprotections
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRequiredProtections(out uint pFrameProtectionFlags);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengineprotectedcontent-setopmwindow
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetOPMWindow(HWND hwnd);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengineprotectedcontent-transfervideoframe
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TransferVideoFrame(nint pDstSurf, nint /* optional MFVideoNormalizedRect* */ pSrc, in RECT pDst, nint /* optional MFARGB* */ pBorderClr, out uint pFrameProtectionFlags);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengineprotectedcontent-setcontentprotectionmanager
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetContentProtectionManager([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFContentProtectionManager?>))] IMFContentProtectionManager? pCPM);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengineprotectedcontent-setapplicationcertificate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetApplicationCertificate(nint /* byte array */ pbBlob, uint cbBlob);
}
