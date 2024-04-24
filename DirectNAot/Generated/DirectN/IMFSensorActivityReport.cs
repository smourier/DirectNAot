namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfsensoractivityreport
[SupportedOSPlatform("windows10.0.15063")]
[GeneratedComInterface, Guid("3e8c4be1-a8c2-4528-90de-2851bde5fead")]
public partial interface IMFSensorActivityReport
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsensoractivityreport-getfriendlyname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFriendlyName([MarshalUsing(CountElementName = nameof(cchFriendlyName))] out PWSTR[] FriendlyName, uint cchFriendlyName, out uint pcchWritten);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsensoractivityreport-getsymboliclink
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSymbolicLink([MarshalUsing(CountElementName = nameof(cchSymbolicLink))] out PWSTR[] SymbolicLink, uint cchSymbolicLink, out uint pcchWritten);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsensoractivityreport-getprocesscount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProcessCount(out uint pcCount);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsensoractivityreport-getprocessactivity
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProcessActivity(uint Index, out IMFSensorProcessActivity ppProcessActivity);
}
