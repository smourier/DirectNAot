namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/bdaiface/nn-bdaiface-ibda_drmservice
[GeneratedComInterface, Guid("bff6b5bb-b0ae-484c-9dca-73528fb0b46e")]
public partial interface IBDA_DRMService
{
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_drmservice-setdrm
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDRM(in Guid puuidNewDrm);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_drmservice-getdrmstatus
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDRMStatus(out BSTR pbstrDrmUuidList, out Guid DrmUuid);
}
