namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfvirtualcamera/nn-mfvirtualcamera-imfvirtualcamera
[GeneratedComInterface, Guid("1c08a864-ef6c-4c75-af59-5f2d68da9563")]
public partial interface IMFVirtualCamera : IMFAttributes
{
    // https://learn.microsoft.com/windows/win32/api/mfvirtualcamera/nf-mfvirtualcamera-imfvirtualcamera-adddevicesourceinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddDeviceSourceInfo(PWSTR DeviceSourceInfo);
    
    // https://learn.microsoft.com/windows/win32/api/mfvirtualcamera/nf-mfvirtualcamera-imfvirtualcamera-addproperty
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddProperty(in DEVPROPKEY pKey, DEVPROPTYPE Type, nint /* byte array */ pbData, uint cbData);
    
    // https://learn.microsoft.com/windows/win32/api/mfvirtualcamera/nf-mfvirtualcamera-imfvirtualcamera-addregistryentry
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddRegistryEntry(PWSTR EntryName, PWSTR? SubkeyPath, uint dwRegType, nint /* byte array */ pbData, uint cbData);
    
    // https://learn.microsoft.com/windows/win32/api/mfvirtualcamera/nf-mfvirtualcamera-imfvirtualcamera-start
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Start(IMFAsyncCallback? pCallback);
    
    // https://learn.microsoft.com/windows/win32/api/mfvirtualcamera/nf-mfvirtualcamera-imfvirtualcamera-stop
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Stop();
    
    // https://learn.microsoft.com/windows/win32/api/mfvirtualcamera/nf-mfvirtualcamera-imfvirtualcamera-remove
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Remove();
    
    // https://learn.microsoft.com/windows/win32/api/mfvirtualcamera/nf-mfvirtualcamera-imfvirtualcamera-getmediasource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMediaSource(out IMFMediaSource ppMediaSource);
    
    // https://learn.microsoft.com/windows/win32/api/mfvirtualcamera/nf-mfvirtualcamera-imfvirtualcamera-sendcameraproperty
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SendCameraProperty(in Guid propertySet, uint propertyId, uint propertyFlags, nint /* optional void* */ propertyPayload, uint propertyPayloadLength, nint /* optional void* */ data, uint dataLength, out uint dataWritten);
    
    // https://learn.microsoft.com/windows/win32/api/mfvirtualcamera/nf-mfvirtualcamera-imfvirtualcamera-createsyncevent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateSyncEvent(in Guid kseventSet, uint kseventId, uint kseventFlags, HANDLE eventHandle, out IMFCameraSyncObject cameraSyncObject);
    
    // https://learn.microsoft.com/windows/win32/api/mfvirtualcamera/nf-mfvirtualcamera-imfvirtualcamera-createsyncsemaphore
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateSyncSemaphore(in Guid kseventSet, uint kseventId, uint kseventFlags, HANDLE semaphoreHandle, int semaphoreAdjustment, out IMFCameraSyncObject cameraSyncObject);
    
    // https://learn.microsoft.com/windows/win32/api/mfvirtualcamera/nf-mfvirtualcamera-imfvirtualcamera-shutdown
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Shutdown();
}
