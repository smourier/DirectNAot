namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfd3d12/nn-mfd3d12-imfd3d12synchronizationobject
[GeneratedComInterface, Guid("802302b0-82de-45e1-b421-f19ee5bdaf23")]
public partial interface IMFD3D12SynchronizationObject
{
    // https://learn.microsoft.com/windows/win32/api/mfd3d12/nf-mfd3d12-imfd3d12synchronizationobject-signaleventonfinalresourcerelease
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SignalEventOnFinalResourceRelease(HANDLE hEvent);
    
    // https://learn.microsoft.com/windows/win32/api/mfd3d12/nf-mfd3d12-imfd3d12synchronizationobject-reset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Reset();
}
