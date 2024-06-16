#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/sbe/nn-sbe-istreambufferconfigure3
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("7e2d2a1e-7192-4bd7-80c1-061fd1d10402")]
public partial interface IStreamBufferConfigure3 : IStreamBufferConfigure2
{
    // https://learn.microsoft.com/windows/win32/api/sbe/nf-sbe-istreambufferconfigure3-setstartrecconfig
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetStartRecConfig(BOOL fStartStopsCur);
    
    // https://learn.microsoft.com/windows/win32/api/sbe/nf-sbe-istreambufferconfigure3-getstartrecconfig
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStartRecConfig(out BOOL pfStartStopsCur);
    
    // https://learn.microsoft.com/windows/win32/api/sbe/nf-sbe-istreambufferconfigure3-setnamespace
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetNamespace(PWSTR pszNamespace);
    
    // https://learn.microsoft.com/windows/win32/api/sbe/nf-sbe-istreambufferconfigure3-getnamespace
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNamespace(out PWSTR ppszNamespace);
}
