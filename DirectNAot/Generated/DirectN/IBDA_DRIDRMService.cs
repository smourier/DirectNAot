#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/bdaiface/nn-bdaiface-ibda_dridrmservice
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("1f9bc2a5-44a3-4c52-aab1-0bbce5a1381d")]
public partial interface IBDA_DRIDRMService
{
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_dridrmservice-setdrm
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDRM(BSTR bstrNewDrm);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_dridrmservice-getdrmstatus
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDRMStatus(out BSTR pbstrDrmUuidList, out Guid DrmUuid);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_dridrmservice-getpairingstatus
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPairingStatus(ref BDA_DrmPairingError penumPairingStatus);
}
