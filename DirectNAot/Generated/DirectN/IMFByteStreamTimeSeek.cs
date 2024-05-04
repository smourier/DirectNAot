#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfbytestreamtimeseek
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("64976bfa-fb61-4041-9069-8c9a5f659beb")]
public partial interface IMFByteStreamTimeSeek
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfbytestreamtimeseek-istimeseeksupported
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsTimeSeekSupported([MarshalAs(UnmanagedType.U4)] out bool pfTimeSeekIsSupported);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfbytestreamtimeseek-timeseek
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TimeSeek(ulong qwTimePosition);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfbytestreamtimeseek-gettimeseekresult
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTimeSeekResult(out ulong pqwStartTime, out ulong pqwStopTime, out ulong pqwDuration);
}
