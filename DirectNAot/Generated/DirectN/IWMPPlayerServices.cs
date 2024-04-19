namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmp/nn-wmp-iwmpplayerservices
[GeneratedComInterface, Guid("1d01fbdb-ade2-4c8d-9842-c190b95c3306")]
public partial interface IWMPPlayerServices
{
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpplayerservices-activateuiplugin
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT activateUIPlugin(BSTR bstrPlugin);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpplayerservices-settaskpane
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT setTaskPane(BSTR bstrTaskPane);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpplayerservices-settaskpaneurl
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT setTaskPaneURL(BSTR bstrTaskPane, BSTR bstrURL, BSTR bstrFriendlyName);
}
