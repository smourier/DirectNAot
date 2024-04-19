namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/bdaiface/nn-bdaiface-ibda_signalproperties
[GeneratedComInterface, Guid("d2f1644b-b409-11d2-bc69-00a0c9ee9e16")]
public partial interface IBDA_SignalProperties
{
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_signalproperties-putnetworktype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PutNetworkType(in Guid guidNetworkType);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_signalproperties-getnetworktype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNetworkType(ref Guid pguidNetworkType);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_signalproperties-putsignalsource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PutSignalSource(uint ulSignalSource);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_signalproperties-getsignalsource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSignalSource(ref uint pulSignalSource);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_signalproperties-puttuningspace
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PutTuningSpace(in Guid guidTuningSpace);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_signalproperties-gettuningspace
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTuningSpace(ref Guid pguidTuingSpace);
}
