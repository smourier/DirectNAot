namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfcontentdecryptorcontext
[SupportedOSPlatform("windows10.0.10240")]
[GeneratedComInterface, Guid("7ec4b1bd-43fb-4763-85d2-64fcb5c5f4cb")]
public partial interface IMFContentDecryptorContext
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfcontentdecryptorcontext-initializehardwarekey
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InitializeHardwareKey(uint InputPrivateDataByteCount, nint /* optional void */ InputPrivateData, out ulong OutputPrivateData);
}
