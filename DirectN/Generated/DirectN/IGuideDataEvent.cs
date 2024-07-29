#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/bdatif/nn-bdatif-iguidedataevent
[GeneratedComInterface, Guid("efda0c80-f395-42c3-9b3c-56b37dec7bb7")]
public partial interface IGuideDataEvent
{
    // https://learn.microsoft.com/windows/win32/api/bdatif/nf-bdatif-iguidedataevent-guidedataacquired
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GuideDataAcquired();
    
    // https://learn.microsoft.com/windows/win32/api/bdatif/nf-bdatif-iguidedataevent-programchanged
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ProgramChanged(VARIANT varProgramDescriptionID);
    
    // https://learn.microsoft.com/windows/win32/api/bdatif/nf-bdatif-iguidedataevent-servicechanged
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ServiceChanged(VARIANT varServiceDescriptionID);
    
    // https://learn.microsoft.com/windows/win32/api/bdatif/nf-bdatif-iguidedataevent-scheduleentrychanged
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ScheduleEntryChanged(VARIANT varScheduleEntryDescriptionID);
    
    // https://learn.microsoft.com/windows/win32/api/bdatif/nf-bdatif-iguidedataevent-programdeleted
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ProgramDeleted(VARIANT varProgramDescriptionID);
    
    // https://learn.microsoft.com/windows/win32/api/bdatif/nf-bdatif-iguidedataevent-servicedeleted
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ServiceDeleted(VARIANT varServiceDescriptionID);
    
    // https://learn.microsoft.com/windows/win32/api/bdatif/nf-bdatif-iguidedataevent-scheduledeleted
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ScheduleDeleted(VARIANT varScheduleEntryDescriptionID);
}
