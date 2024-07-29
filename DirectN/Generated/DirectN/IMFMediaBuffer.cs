#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfobjects/nn-mfobjects-imfmediabuffer
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("045fa593-8799-42b8-bc8d-8968c6453507")]
public partial interface IMFMediaBuffer
{
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfmediabuffer-lock
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Lock(out nint /* byte array */ ppbBuffer, nint /* optional uint* */ pcbMaxLength, nint /* optional uint* */ pcbCurrentLength);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfmediabuffer-unlock
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Unlock();
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfmediabuffer-getcurrentlength
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrentLength(out uint pcbCurrentLength);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfmediabuffer-setcurrentlength
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCurrentLength(uint cbCurrentLength);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfmediabuffer-getmaxlength
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMaxLength(out uint pcbMaxLength);
}
