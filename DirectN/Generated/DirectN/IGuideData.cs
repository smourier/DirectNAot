#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/bdatif/nn-bdatif-iguidedata
[GeneratedComInterface, Guid("61571138-5b01-43cd-aeaf-60b784a0bf93")]
public partial interface IGuideData
{
    // https://learn.microsoft.com/windows/win32/api/bdatif/nf-bdatif-iguidedata-getservices
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetServices([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumTuneRequests>))] out IEnumTuneRequests ppEnumTuneRequests);
    
    // https://learn.microsoft.com/windows/win32/api/bdatif/nf-bdatif-iguidedata-getserviceproperties
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetServiceProperties(ITuneRequest pTuneRequest, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumGuideDataProperties>))] out IEnumGuideDataProperties ppEnumProperties);
    
    // https://learn.microsoft.com/windows/win32/api/bdatif/nf-bdatif-iguidedata-getguideprogramids
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGuideProgramIDs([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumVARIANT>))] out IEnumVARIANT pEnumPrograms);
    
    // https://learn.microsoft.com/windows/win32/api/bdatif/nf-bdatif-iguidedata-getprogramproperties
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProgramProperties(VARIANT varProgramDescriptionID, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumGuideDataProperties>))] out IEnumGuideDataProperties ppEnumProperties);
    
    // https://learn.microsoft.com/windows/win32/api/bdatif/nf-bdatif-iguidedata-getscheduleentryids
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetScheduleEntryIDs([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumVARIANT>))] out IEnumVARIANT pEnumScheduleEntries);
    
    // https://learn.microsoft.com/windows/win32/api/bdatif/nf-bdatif-iguidedata-getscheduleentryproperties
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetScheduleEntryProperties(VARIANT varScheduleEntryDescriptionID, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumGuideDataProperties>))] out IEnumGuideDataProperties ppEnumProperties);
}
