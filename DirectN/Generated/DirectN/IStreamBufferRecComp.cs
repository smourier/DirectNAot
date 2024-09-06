#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/sbe/nn-sbe-istreambufferreccomp
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("9e259a9b-8815-42ae-b09f-221970b154fd")]
public partial interface IStreamBufferRecComp
{
    // https://learn.microsoft.com/windows/win32/api/sbe/nf-sbe-istreambufferreccomp-initialize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize(PWSTR pszTargetFilename, PWSTR pszSBRecProfileRef);
    
    // https://learn.microsoft.com/windows/win32/api/sbe/nf-sbe-istreambufferreccomp-append
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Append(PWSTR pszSBRecording);
    
    // https://learn.microsoft.com/windows/win32/api/sbe/nf-sbe-istreambufferreccomp-appendex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AppendEx(PWSTR pszSBRecording, long rtStart, long rtStop);
    
    // https://learn.microsoft.com/windows/win32/api/sbe/nf-sbe-istreambufferreccomp-getcurrentlength
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrentLength(out uint pcSeconds);
    
    // https://learn.microsoft.com/windows/win32/api/sbe/nf-sbe-istreambufferreccomp-close
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Close();
    
    // https://learn.microsoft.com/windows/win32/api/sbe/nf-sbe-istreambufferreccomp-cancel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Cancel();
}
