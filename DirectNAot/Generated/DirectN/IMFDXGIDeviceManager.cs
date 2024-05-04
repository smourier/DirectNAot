#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfobjects/nn-mfobjects-imfdxgidevicemanager
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("eb533d5d-2db6-40f8-97a9-494692014f07")]
public partial interface IMFDXGIDeviceManager
{
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfdxgidevicemanager-closedevicehandle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CloseDeviceHandle(HANDLE hDevice);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfdxgidevicemanager-getvideoservice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVideoService(HANDLE hDevice, in Guid riid, out nint ppService);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfdxgidevicemanager-lockdevice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LockDevice(HANDLE hDevice, in Guid riid, out nint ppUnkDevice, [MarshalAs(UnmanagedType.U4)] bool fBlock);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfdxgidevicemanager-opendevicehandle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OpenDeviceHandle(out HANDLE phDevice);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfdxgidevicemanager-resetdevice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ResetDevice(nint pUnkDevice, uint resetToken);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfdxgidevicemanager-testdevice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TestDevice(HANDLE hDevice);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfdxgidevicemanager-unlockdevice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnlockDevice(HANDLE hDevice, [MarshalAs(UnmanagedType.U4)] bool fSaveState);
}
