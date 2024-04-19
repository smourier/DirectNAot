namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfmediasourceex
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("3c9b2eb9-86d5-4514-a394-f56664f9f0d8")]
public partial interface IMFMediaSourceEx : IMFMediaSource
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfmediasourceex-getsourceattributes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSourceAttributes(out IMFAttributes ppAttributes);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfmediasourceex-getstreamattributes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStreamAttributes(uint dwStreamIdentifier, out IMFAttributes ppAttributes);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfmediasourceex-setd3dmanager
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetD3DManager(nint pManager);
}
