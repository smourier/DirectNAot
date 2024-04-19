namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/videoacc/nn-videoacc-iamvideoacceleratornotify
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("256a6a21-fbad-11d1-82bf-00a0c9696c8f")]
public partial interface IAMVideoAcceleratorNotify
{
    // https://learn.microsoft.com/windows/win32/api/videoacc/nf-videoacc-iamvideoacceleratornotify-getuncompsurfacesinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetUncompSurfacesInfo(in Guid pGuid, ref AMVAUncompBufferInfo pUncompBufferInfo);
    
    // https://learn.microsoft.com/windows/win32/api/videoacc/nf-videoacc-iamvideoacceleratornotify-setuncompsurfacesinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetUncompSurfacesInfo(uint dwActualUncompSurfacesAllocated);
    
    // https://learn.microsoft.com/windows/win32/api/videoacc/nf-videoacc-iamvideoacceleratornotify-getcreatevideoacceleratordata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCreateVideoAcceleratorData(in Guid pGuid, out uint pdwSizeMiscData, out nint ppMiscData);
}
