namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/contentpartner/nn-contentpartner-iwmpcontentpartnercallback
[GeneratedComInterface, Guid("9e8f7da2-0695-403c-b697-da10fafaa676")]
public partial interface IWMPContentPartnerCallback
{
    // https://learn.microsoft.com/windows/win32/api/contentpartner/nf-contentpartner-iwmpcontentpartnercallback-notify
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Notify(WMPCallbackNotification type, in VARIANT pContext);
    
    // https://learn.microsoft.com/windows/win32/api/contentpartner/nf-contentpartner-iwmpcontentpartnercallback-buycomplete
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BuyComplete(HRESULT hrResult, uint dwBuyCookie);
    
    // https://learn.microsoft.com/windows/win32/api/contentpartner/nf-contentpartner-iwmpcontentpartnercallback-downloadtrack
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DownloadTrack(uint cookie, BSTR bstrTrackURL, uint dwServiceTrackID, BSTR bstrDownloadParams, HRESULT hrDownload);
    
    // https://learn.microsoft.com/windows/win32/api/contentpartner/nf-contentpartner-iwmpcontentpartnercallback-getcatalogversion
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCatalogVersion(out uint pdwVersion, out uint pdwSchemaVersion, out uint plcid);
    
    // https://learn.microsoft.com/windows/win32/api/contentpartner/nf-contentpartner-iwmpcontentpartnercallback-updatedevicecomplete
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UpdateDeviceComplete(BSTR bstrDeviceName);
    
    // https://learn.microsoft.com/windows/win32/api/contentpartner/nf-contentpartner-iwmpcontentpartnercallback-changeview
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ChangeView(BSTR bstrType, BSTR bstrID, BSTR bstrFilter);
    
    // https://learn.microsoft.com/windows/win32/api/contentpartner/nf-contentpartner-iwmpcontentpartnercallback-addlistcontents
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddListContents(uint dwListCookie, uint cItems, [MarshalUsing(CountElementName = nameof(cItems))] in uint[] prgItems);
    
    // https://learn.microsoft.com/windows/win32/api/contentpartner/nf-contentpartner-iwmpcontentpartnercallback-listcontentscomplete
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ListContentsComplete(uint dwListCookie, HRESULT hrSuccess);
    
    // https://learn.microsoft.com/windows/win32/api/contentpartner/nf-contentpartner-iwmpcontentpartnercallback-sendmessagecomplete
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SendMessageComplete(BSTR bstrMsg, BSTR bstrParam, BSTR bstrResult);
    
    // https://learn.microsoft.com/windows/win32/api/contentpartner/nf-contentpartner-iwmpcontentpartnercallback-getcontentidsinlibrary
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetContentIDsInLibrary(out uint pcContentIDs, out nint pprgIDs);
    
    // https://learn.microsoft.com/windows/win32/api/contentpartner/nf-contentpartner-iwmpcontentpartnercallback-refreshlicensecomplete
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RefreshLicenseComplete(uint dwCookie, uint contentID, HRESULT hrRefresh);
    
    // https://learn.microsoft.com/windows/win32/api/contentpartner/nf-contentpartner-iwmpcontentpartnercallback-showpopup
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ShowPopup(int lIndex, BSTR bstrParameters);
    
    // https://learn.microsoft.com/windows/win32/api/contentpartner/nf-contentpartner-iwmpcontentpartnercallback-verifypermissioncomplete
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT VerifyPermissionComplete(BSTR bstrPermission, in VARIANT pContext, HRESULT hrPermission);
}
