namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/bdatif/nn-bdatif-ibda_tif_registration
[GeneratedComInterface, Guid("dfef4a68-ee61-415f-9ccb-cd95f2f98a3a")]
public partial interface IBDA_TIF_REGISTRATION
{
    // https://learn.microsoft.com/windows/win32/api/bdatif/nf-bdatif-ibda_tif_registration-registertifex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterTIFEx(IPin pTIFInputPin, ref uint ppvRegistrationContext, ref nint ppMpeg2DataControl);
    
    // https://learn.microsoft.com/windows/win32/api/bdatif/nf-bdatif-ibda_tif_registration-unregistertif
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnregisterTIF(uint pvRegistrationContext);
}
