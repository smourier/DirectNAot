namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tuner/nn-tuner-idvbslocator
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("3d7c353c-0d04-45f1-a742-f97cc1188dc8")]
public partial interface IDVBSLocator : IDigitalLocator
{
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-idvbslocator-get_signalpolarisation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_SignalPolarisation(out Polarisation PolarisationVal);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-idvbslocator-put_signalpolarisation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_SignalPolarisation(Polarisation PolarisationVal);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-idvbslocator-get_westposition
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_WestPosition(out VARIANT_BOOL WestLongitude);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-idvbslocator-put_westposition
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_WestPosition(VARIANT_BOOL WestLongitude);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-idvbslocator-get_orbitalposition
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_OrbitalPosition(out int longitude);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-idvbslocator-put_orbitalposition
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_OrbitalPosition(int longitude);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-idvbslocator-get_azimuth
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Azimuth(out int Azimuth);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-idvbslocator-put_azimuth
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Azimuth(int Azimuth);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-idvbslocator-get_elevation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Elevation(out int Elevation);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-idvbslocator-put_elevation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Elevation(int Elevation);
}
