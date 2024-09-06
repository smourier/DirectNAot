#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfbytestreamcachecontrol
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("f5042ea4-7a96-4a75-aa7b-2be1ef7f88d5")]
public partial interface IMFByteStreamCacheControl
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfbytestreamcachecontrol-stopbackgroundtransfer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StopBackgroundTransfer();
}
