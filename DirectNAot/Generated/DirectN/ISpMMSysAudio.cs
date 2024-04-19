namespace DirectN;

[GeneratedComInterface, Guid("15806f6e-1d70-4b48-98e6-3b1a007509ab")]
public partial interface ISpMMSysAudio : ISpAudio
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDeviceId(ref uint puDeviceId);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDeviceId(uint uDeviceId);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMMHandle(out nint pHandle);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLineId(ref uint puLineId);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetLineId(uint uLineId);
}
