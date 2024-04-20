namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/devicetopology/nn-devicetopology-iaudioloudness
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("7d8b1437-dd53-4350-9c1b-1ee2890bd938")]
public partial interface IAudioLoudness
{
    // https://learn.microsoft.com/windows/win32/api/devicetopology/nf-devicetopology-iaudioloudness-getenabled
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEnabled([MarshalAs(UnmanagedType.U4)] out bool pbEnabled);
    
    // https://learn.microsoft.com/windows/win32/api/devicetopology/nf-devicetopology-iaudioloudness-setenabled
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetEnabled([MarshalAs(UnmanagedType.U4)] bool bEnable, nint /* optional Guid */ pguidEventContext);
}
