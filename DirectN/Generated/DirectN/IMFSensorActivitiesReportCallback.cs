#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfsensoractivitiesreportcallback
[SupportedOSPlatform("windows10.0.15063")]
[GeneratedComInterface, Guid("de5072ee-dbe3-46dc-8a87-b6f631194751")]
public partial interface IMFSensorActivitiesReportCallback
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsensoractivitiesreportcallback-onactivitiesreport
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnActivitiesReport([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFSensorActivitiesReport>))] IMFSensorActivitiesReport sensorActivitiesReport);
}
