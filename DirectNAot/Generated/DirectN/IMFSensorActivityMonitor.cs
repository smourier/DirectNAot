namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfsensoractivitymonitor
[SupportedOSPlatform("windows10.0.15063")]
[GeneratedComInterface, Guid("d0cef145-b3f4-4340-a2e5-7a5080ca05cb")]
public partial interface IMFSensorActivityMonitor
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsensoractivitymonitor-start
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Start();
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsensoractivitymonitor-stop
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Stop();
}
