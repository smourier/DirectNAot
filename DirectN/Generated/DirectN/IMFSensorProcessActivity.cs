#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfsensorprocessactivity
[SupportedOSPlatform("windows10.0.15063")]
[GeneratedComInterface, Guid("39dc7f4a-b141-4719-813c-a7f46162a2b8")]
public partial interface IMFSensorProcessActivity
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsensorprocessactivity-getprocessid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProcessId(out uint pPID);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsensorprocessactivity-getstreamingstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStreamingState(out BOOL pfStreaming);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsensorprocessactivity-getstreamingmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStreamingMode(out MFSensorDeviceMode pMode);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsensorprocessactivity-getreporttime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetReportTime(out FILETIME pft);
}
