namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfcameracontroldefaults
[GeneratedComInterface, Guid("75510662-b034-48f4-88a7-8de61daa4af9")]
public partial interface IMFCameraControlDefaults
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfcameracontroldefaults-gettype
    [PreserveSig]
    MF_CAMERA_CONTROL_CONFIGURATION_TYPE GetType();
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfcameracontroldefaults-getrangeinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRangeInfo(out MF_CAMERA_CONTROL_RANGE_INFO rangeInfo);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfcameracontroldefaults-lockcontroldata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LockControlData(out nint control, out uint controlSize, nint/* nint */ data, nint/* nint */ dataSize);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfcameracontroldefaults-unlockcontroldata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnlockControlData();
}
