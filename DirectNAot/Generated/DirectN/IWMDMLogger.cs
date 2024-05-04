#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmdmlog/nn-wmdmlog-iwmdmlogger
[GeneratedComInterface, Guid("110a3200-5a79-11d3-8d78-444553540000")]
public partial interface IWMDMLogger
{
    // https://learn.microsoft.com/windows/win32/api/wmdmlog/nf-wmdmlog-iwmdmlogger-isenabled
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsEnabled([MarshalAs(UnmanagedType.U4)] out bool pfEnabled);
    
    // https://learn.microsoft.com/windows/win32/api/wmdmlog/nf-wmdmlog-iwmdmlogger-enable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Enable([MarshalAs(UnmanagedType.U4)] bool fEnable);
    
    // https://learn.microsoft.com/windows/win32/api/wmdmlog/nf-wmdmlog-iwmdmlogger-getlogfilename
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLogFileName(out PSTR pszFilename, uint nMaxChars);
    
    // https://learn.microsoft.com/windows/win32/api/wmdmlog/nf-wmdmlog-iwmdmlogger-setlogfilename
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetLogFileName(PSTR pszFilename);
    
    // https://learn.microsoft.com/windows/win32/api/wmdmlog/nf-wmdmlog-iwmdmlogger-logstring
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LogString(uint dwFlags, PSTR pszSrcName, PSTR pszLog);
    
    // https://learn.microsoft.com/windows/win32/api/wmdmlog/nf-wmdmlog-iwmdmlogger-logdword
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LogDword(uint dwFlags, PSTR pszSrcName, PSTR pszLogFormat, uint dwLog);
    
    // https://learn.microsoft.com/windows/win32/api/wmdmlog/nf-wmdmlog-iwmdmlogger-reset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Reset();
    
    // https://learn.microsoft.com/windows/win32/api/wmdmlog/nf-wmdmlog-iwmdmlogger-getsizeparams
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSizeParams(out uint pdwMaxSize, out uint pdwShrinkToSize);
    
    // https://learn.microsoft.com/windows/win32/api/wmdmlog/nf-wmdmlog-iwmdmlogger-setsizeparams
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSizeParams(uint dwMaxSize, uint dwShrinkToSize);
}
