#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfstreamingsinkconfig
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("9db7aa41-3cc5-40d4-8509-555804ad34cc")]
public partial interface IMFStreamingSinkConfig
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfstreamingsinkconfig-startstreaming
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StartStreaming(BOOL fSeekOffsetIsByteOffset, ulong qwSeekOffset);
}
