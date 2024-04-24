namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/bdaiface/nn-bdaiface-ibda_conditionalaccess
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("cd51f1e0-7be9-4123-8482-a2a796c0a6b0")]
public partial interface IBDA_ConditionalAccess
{
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_conditionalaccess-get_smartcardstatus
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_SmartCardStatus(out SmartCardStatusType pCardStatus, out SmartCardAssociationType pCardAssociation, out BSTR pbstrCardError, out VARIANT_BOOL pfOOBLocked);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_conditionalaccess-get_smartcardinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_SmartCardInfo(out BSTR pbstrCardName, out BSTR pbstrCardManufacturer, out VARIANT_BOOL pfDaylightSavings, nint /* byte array */ pbyRatingRegion, out int plTimeZoneOffsetMinutes, out BSTR pbstrLanguage, out EALocationCodeType pEALocationCode);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_conditionalaccess-get_smartcardapplications
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_SmartCardApplications(ref uint pulcApplications, uint ulcApplicationsMax, [MarshalUsing(CountElementName = nameof(ulcApplicationsMax))] ref SmartCardApplication[] rgApplications);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_conditionalaccess-get_entitlement
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Entitlement(ushort usVirtualChannel, out EntitlementType pEntitlement);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_conditionalaccess-tunebychannel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TuneByChannel(ushort usVirtualChannel);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_conditionalaccess-setprogram
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetProgram(ushort usProgramNumber);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_conditionalaccess-addprogram
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddProgram(ushort usProgramNumber);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_conditionalaccess-removeprogram
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveProgram(ushort usProgramNumber);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_conditionalaccess-getmoduleui
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetModuleUI(byte byDialogNumber, out BSTR pbstrURL);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_conditionalaccess-informuiclosed
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InformUIClosed(byte byDialogNumber, UICloseReasonType CloseReason);
}
