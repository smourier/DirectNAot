namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfclock
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("2eb1e945-18b8-4139-9b1a-d5d584818530")]
public partial interface IMFClock
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfclock-getclockcharacteristics
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetClockCharacteristics(out uint pdwCharacteristics);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfclock-getcorrelatedtime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCorrelatedTime(uint dwReserved, out long pllClockTime, out long phnsSystemTime);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfclock-getcontinuitykey
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetContinuityKey(out uint pdwContinuityKey);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfclock-getstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetState(uint dwReserved, out MFCLOCK_STATE peClockState);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfclock-getproperties
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProperties(out MFCLOCK_PROPERTIES pClockProperties);
}
