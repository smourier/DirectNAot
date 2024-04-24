namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/devicetopology/nn-devicetopology-iaudiochannelconfig
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("bb11c46f-ec28-493c-b88a-5db88062ce98")]
public partial interface IAudioChannelConfig
{
    // https://learn.microsoft.com/windows/win32/api/devicetopology/nf-devicetopology-iaudiochannelconfig-setchannelconfig
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetChannelConfig(uint dwConfig, nint /* optional Guid* */ pguidEventContext);
    
    // https://learn.microsoft.com/windows/win32/api/devicetopology/nf-devicetopology-iaudiochannelconfig-getchannelconfig
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetChannelConfig(out uint pdwConfig);
}
