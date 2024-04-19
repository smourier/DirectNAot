namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/bdatif/nn-bdatif-iguidedata
[GeneratedComInterface, Guid("61571138-5b01-43cd-aeaf-60b784a0bf93")]
public partial interface IGuideData
{
    // https://learn.microsoft.com/windows/win32/api/bdatif/nf-bdatif-iguidedata-getservices
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetServices(out IEnumTuneRequests ppEnumTuneRequests);
    
    // https://learn.microsoft.com/windows/win32/api/bdatif/nf-bdatif-iguidedata-getserviceproperties
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetServiceProperties(ITuneRequest pTuneRequest, out IEnumGuideDataProperties ppEnumProperties);
    
    // https://learn.microsoft.com/windows/win32/api/bdatif/nf-bdatif-iguidedata-getguideprogramids
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGuideProgramIDs(out IEnumVARIANT pEnumPrograms);
    
    // https://learn.microsoft.com/windows/win32/api/bdatif/nf-bdatif-iguidedata-getprogramproperties
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProgramProperties(VARIANT varProgramDescriptionID, out IEnumGuideDataProperties ppEnumProperties);
    
    // https://learn.microsoft.com/windows/win32/api/bdatif/nf-bdatif-iguidedata-getscheduleentryids
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetScheduleEntryIDs(out IEnumVARIANT pEnumScheduleEntries);
    
    // https://learn.microsoft.com/windows/win32/api/bdatif/nf-bdatif-iguidedata-getscheduleentryproperties
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetScheduleEntryProperties(VARIANT varScheduleEntryDescriptionID, out IEnumGuideDataProperties ppEnumProperties);
}
