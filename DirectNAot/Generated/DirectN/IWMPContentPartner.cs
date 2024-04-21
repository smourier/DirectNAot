namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/contentpartner/nn-contentpartner-iwmpcontentpartner
[GeneratedComInterface, Guid("55455073-41b5-4e75-87b8-f13bdb291d08")]
public partial interface IWMPContentPartner
{
    // https://learn.microsoft.com/windows/win32/api/contentpartner/nf-contentpartner-iwmpcontentpartner-setcallback
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCallback(IWMPContentPartnerCallback? pCallback);
    
    // https://learn.microsoft.com/windows/win32/api/contentpartner/nf-contentpartner-iwmpcontentpartner-notify
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Notify(WMPPartnerNotification type, in VARIANT pContext);
    
    // https://learn.microsoft.com/windows/win32/api/contentpartner/nf-contentpartner-iwmpcontentpartner-getiteminfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetItemInfo(BSTR bstrInfoName, in VARIANT pContext, out VARIANT pData);
    
    // https://learn.microsoft.com/windows/win32/api/contentpartner/nf-contentpartner-iwmpcontentpartner-getcontentpartnerinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetContentPartnerInfo(BSTR bstrInfoName, out VARIANT pData);
    
    // https://learn.microsoft.com/windows/win32/api/contentpartner/nf-contentpartner-iwmpcontentpartner-getcommands
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCommands(BSTR location, in VARIANT pLocationContext, BSTR itemLocation, uint cItemIDs, in uint prgItemIDs, out uint pcItemIDs, out WMPContextMenuInfo pprgItems);
    
    // https://learn.microsoft.com/windows/win32/api/contentpartner/nf-contentpartner-iwmpcontentpartner-invokecommand
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InvokeCommand(uint dwCommandID, BSTR location, in VARIANT pLocationContext, BSTR itemLocation, uint cItemIDs, in uint rgItemIDs);
    
    // https://learn.microsoft.com/windows/win32/api/contentpartner/nf-contentpartner-iwmpcontentpartner-canbuysilent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CanBuySilent(IWMPContentContainerList? pInfo, out BSTR pbstrTotalPrice, out VARIANT_BOOL pSilentOK);
    
    // https://learn.microsoft.com/windows/win32/api/contentpartner/nf-contentpartner-iwmpcontentpartner-buy
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Buy(IWMPContentContainerList? pInfo, uint cookie);
    
    // https://learn.microsoft.com/windows/win32/api/contentpartner/nf-contentpartner-iwmpcontentpartner-getstreamingurl
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStreamingURL(WMPStreamingType st, in VARIANT pStreamContext, out BSTR pbstrURL);
    
    // https://learn.microsoft.com/windows/win32/api/contentpartner/nf-contentpartner-iwmpcontentpartner-download
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Download(IWMPContentContainerList? pInfo, uint cookie);
    
    // https://learn.microsoft.com/windows/win32/api/contentpartner/nf-contentpartner-iwmpcontentpartner-downloadtrackcomplete
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DownloadTrackComplete(HRESULT hrResult, uint contentID, BSTR downloadTrackParam);
    
    // https://learn.microsoft.com/windows/win32/api/contentpartner/nf-contentpartner-iwmpcontentpartner-refreshlicense
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RefreshLicense(uint dwCookie, VARIANT_BOOL fLocal, BSTR? bstrURL, WMPStreamingType type, uint contentID, BSTR bstrRefreshReason, in VARIANT pReasonContext);
    
    // https://learn.microsoft.com/windows/win32/api/contentpartner/nf-contentpartner-iwmpcontentpartner-getcatalogurl
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCatalogURL(uint dwCatalogVersion, uint dwCatalogSchemaVersion, uint catalogLCID, out uint pdwNewCatalogVersion, out BSTR pbstrCatalogURL, out VARIANT pExpirationDate);
    
    // https://learn.microsoft.com/windows/win32/api/contentpartner/nf-contentpartner-iwmpcontentpartner-gettemplate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTemplate(WMPTaskType task, BSTR location, in VARIANT pContext, BSTR clickLocation, in VARIANT pClickContext, BSTR bstrFilter, BSTR bstrViewParams, out BSTR pbstrTemplateURL, out WMPTemplateSize pTemplateSize);
    
    // https://learn.microsoft.com/windows/win32/api/contentpartner/nf-contentpartner-iwmpcontentpartner-updatedevice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UpdateDevice(BSTR bstrDeviceName);
    
    // https://learn.microsoft.com/windows/win32/api/contentpartner/nf-contentpartner-iwmpcontentpartner-getlistcontents
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetListContents(BSTR location, in VARIANT pContext, BSTR bstrListType, BSTR bstrParams, uint dwListCookie);
    
    // https://learn.microsoft.com/windows/win32/api/contentpartner/nf-contentpartner-iwmpcontentpartner-login
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Login(BLOB userInfo, BLOB pwdInfo, VARIANT_BOOL fUsedCachedCreds, VARIANT_BOOL fOkToCache);
    
    // https://learn.microsoft.com/windows/win32/api/contentpartner/nf-contentpartner-iwmpcontentpartner-authenticate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Authenticate(BLOB userInfo, BLOB pwdInfo);
    
    // https://learn.microsoft.com/windows/win32/api/contentpartner/nf-contentpartner-iwmpcontentpartner-logout
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Logout();
    
    // https://learn.microsoft.com/windows/win32/api/contentpartner/nf-contentpartner-iwmpcontentpartner-sendmessage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SendMessage(BSTR bstrMsg, BSTR bstrParam);
    
    // https://learn.microsoft.com/windows/win32/api/contentpartner/nf-contentpartner-iwmpcontentpartner-stationevent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StationEvent(BSTR bstrStationEventType, uint StationId, uint PlaylistIndex, uint TrackID, BSTR TrackData, uint dwSecondsPlayed);
    
    // https://learn.microsoft.com/windows/win32/api/contentpartner/nf-contentpartner-iwmpcontentpartner-comparecontainerlistprices
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CompareContainerListPrices(IWMPContentContainerList? pListBase, IWMPContentContainerList? pListCompare, out int pResult);
    
    // https://learn.microsoft.com/windows/win32/api/contentpartner/nf-contentpartner-iwmpcontentpartner-verifypermission
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT VerifyPermission(BSTR bstrPermission, in VARIANT pContext);
}
