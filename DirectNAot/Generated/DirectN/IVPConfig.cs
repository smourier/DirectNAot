namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vpconfig/nn-vpconfig-ivpconfig
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("bc29a660-30e3-11d0-9e69-00c04fd7c15b")]
public partial interface IVPConfig : IVPBaseConfig
{
    // https://learn.microsoft.com/windows/win32/api/vpconfig/nf-vpconfig-ivpconfig-isvpdecimationallowed
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsVPDecimationAllowed([MarshalAs(UnmanagedType.U4)] ref bool pbIsDecimationAllowed);
    
    // https://learn.microsoft.com/windows/win32/api/vpconfig/nf-vpconfig-ivpconfig-setscalingfactors
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetScalingFactors(ref AMVPSIZE pamvpSize);
}
