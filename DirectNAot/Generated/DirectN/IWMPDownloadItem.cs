namespace DirectN;

[GeneratedComInterface, Guid("c9470e8e-3f6b-46a9-a0a9-452815c34297")]
public partial interface IWMPDownloadItem : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_sourceURL(ref BSTR pbstrURL);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_size(ref int plSize);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_type(ref BSTR pbstrType);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_progress(ref int plProgress);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_downloadState(ref WMPSubscriptionDownloadState pwmpsdls);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT pause();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT resume();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT cancel();
}
