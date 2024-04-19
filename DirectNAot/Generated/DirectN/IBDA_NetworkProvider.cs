namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/bdaiface/nn-bdaiface-ibda_networkprovider
[GeneratedComInterface, Guid("fd501041-8ebe-11ce-8183-00aa00577da2")]
public partial interface IBDA_NetworkProvider
{
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_networkprovider-putsignalsource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PutSignalSource(uint ulSignalSource);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_networkprovider-getsignalsource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSignalSource(ref uint pulSignalSource);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_networkprovider-getnetworktype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNetworkType(ref Guid pguidNetworkType);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_networkprovider-puttuningspace
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PutTuningSpace(in Guid guidTuningSpace);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_networkprovider-gettuningspace
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTuningSpace(ref Guid pguidTuingSpace);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_networkprovider-registerdevicefilter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterDeviceFilter(nint pUnkFilterControl, ref uint ppvRegisitrationContext);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_networkprovider-unregisterdevicefilter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnRegisterDeviceFilter(uint pvRegistrationContext);
}
