#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfobjects/nn-mfobjects-imfasyncresult
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("ac6b7889-0740-4d51-8619-905994a55cc6")]
public partial interface IMFAsyncResult
{
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfasyncresult-getstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetState(out nint ppunkState);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfasyncresult-getstatus
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStatus();
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfasyncresult-setstatus
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetStatus(HRESULT hrStatus);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfasyncresult-getobject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetObject(out nint ppObject);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfasyncresult-getstatenoaddref
    [PreserveSig]
    nint GetStateNoAddRef();
}
