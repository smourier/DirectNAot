namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi1_4/nn-dxgi1_4-idxgiadapter3
[GeneratedComInterface, Guid("645967a4-1392-4310-a798-8053ce3e93fd")]
public partial interface IDXGIAdapter3 : IDXGIAdapter2
{
    // https://learn.microsoft.com/windows/win32/api/dxgi1_4/nf-dxgi1_4-idxgiadapter3-registerhardwarecontentprotectionteardownstatusevent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT RegisterHardwareContentProtectionTeardownStatusEvent(HANDLE hEvent, out uint pdwCookie);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi1_4/nf-dxgi1_4-idxgiadapter3-unregisterhardwarecontentprotectionteardownstatus
    [PreserveSig]
    public void UnregisterHardwareContentProtectionTeardownStatus(uint dwCookie);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi1_4/nf-dxgi1_4-idxgiadapter3-queryvideomemoryinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT QueryVideoMemoryInfo(uint NodeIndex, DXGI_MEMORY_SEGMENT_GROUP MemorySegmentGroup, out DXGI_QUERY_VIDEO_MEMORY_INFO pVideoMemoryInfo);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi1_4/nf-dxgi1_4-idxgiadapter3-setvideomemoryreservation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetVideoMemoryReservation(uint NodeIndex, DXGI_MEMORY_SEGMENT_GROUP MemorySegmentGroup, ulong Reservation);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi1_4/nf-dxgi1_4-idxgiadapter3-registervideomemorybudgetchangenotificationevent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT RegisterVideoMemoryBudgetChangeNotificationEvent(HANDLE hEvent, out uint pdwCookie);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi1_4/nf-dxgi1_4-idxgiadapter3-unregistervideomemorybudgetchangenotification
    [PreserveSig]
    public void UnregisterVideoMemoryBudgetChangeNotification(uint dwCookie);
}
