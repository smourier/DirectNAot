﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfoutputtrustauthority
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("d19f8e94-b126-4446-890c-5dcb7ad71453")]
public partial interface IMFOutputTrustAuthority
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfoutputtrustauthority-getaction
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAction(out MFPOLICYMANAGER_ACTION pAction);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfoutputtrustauthority-setpolicy
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPolicy(nint /* optional IMFOutputPolicy* */ ppPolicy, uint nPolicy, nint /* optional byte** */ ppbTicket, nint /* optional uint* */ pcbTicket);
}
