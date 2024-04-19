namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfratesupport
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("0a9ccdbc-d797-4563-9667-94ec5d79292d")]
public partial interface IMFRateSupport
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfratesupport-getslowestrate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSlowestRate(MFRATE_DIRECTION eDirection, [MarshalAs(UnmanagedType.U4)] bool fThin, out float pflRate);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfratesupport-getfastestrate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFastestRate(MFRATE_DIRECTION eDirection, [MarshalAs(UnmanagedType.U4)] bool fThin, out float pflRate);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfratesupport-isratesupported
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsRateSupported([MarshalAs(UnmanagedType.U4)] bool fThin, float flRate, ref float pflNearestSupportedRate);
}
