#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfsensoractivitiesreport
[SupportedOSPlatform("windows10.0.15063")]
[GeneratedComInterface, Guid("683f7a5e-4a19-43cd-b1a9-dbf4ab3f7777")]
public partial interface IMFSensorActivitiesReport
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsensoractivitiesreport-getcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCount(out uint pcCount);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsensoractivitiesreport-getactivityreport
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetActivityReport(uint Index, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFSensorActivityReport>))] out IMFSensorActivityReport sensorActivityReport);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsensoractivitiesreport-getactivityreportbydevicename
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetActivityReportByDeviceName(PWSTR SymbolicName, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFSensorActivityReport>))] out IMFSensorActivityReport sensorActivityReport);
}
