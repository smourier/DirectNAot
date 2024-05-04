#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imftranscodesinkinfoprovider
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("8cffcd2e-5a03-4a3a-aff7-edcd107c620e")]
public partial interface IMFTranscodeSinkInfoProvider
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imftranscodesinkinfoprovider-setoutputfile
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetOutputFile(PWSTR pwszFileName);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imftranscodesinkinfoprovider-setoutputbytestream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetOutputByteStream(IMFActivate pByteStreamActivate);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imftranscodesinkinfoprovider-setprofile
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetProfile(IMFTranscodeProfile pProfile);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imftranscodesinkinfoprovider-getsinkinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSinkInfo(out MF_TRANSCODE_SINK_INFO pSinkInfo);
}
