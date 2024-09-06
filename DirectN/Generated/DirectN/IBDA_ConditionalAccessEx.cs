#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/bdaiface/nn-bdaiface-ibda_conditionalaccessex
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("497c3418-23cb-44ba-bb62-769f506fcea7")]
public partial interface IBDA_ConditionalAccessEx
{
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_conditionalaccessex-checkentitlementtoken
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CheckEntitlementToken(uint ulDialogRequest, BSTR bstrLanguage, BDA_CONDITIONALACCESS_REQUESTTYPE RequestType, uint ulcbEntitlementTokenLen, nint /* byte array */ pbEntitlementToken, out uint pulDescrambleStatus);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_conditionalaccessex-setcapturetoken
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCaptureToken(uint ulcbCaptureTokenLen, nint /* byte array */ pbCaptureToken);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_conditionalaccessex-openbroadcastmmi
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OpenBroadcastMmi(uint ulDialogRequest, BSTR bstrLanguage, uint EventId);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_conditionalaccessex-closemmidialog
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CloseMmiDialog(uint ulDialogRequest, BSTR bstrLanguage, uint ulDialogNumber, BDA_CONDITIONALACCESS_MMICLOSEREASON ReasonCode, out uint pulSessionResult);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_conditionalaccessex-createdialogrequestnumber
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateDialogRequestNumber(out uint pulDialogRequestNumber);
}
