#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmreaderadvanced4
[GeneratedComInterface, Guid("945a76a2-12ae-4d48-bd3c-cd1d90399b85")]
public partial interface IWMReaderAdvanced4 : IWMReaderAdvanced3
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreaderadvanced4-getlanguagecount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLanguageCount(uint dwOutputNum, out ushort pwLanguageCount);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreaderadvanced4-getlanguage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLanguage(uint dwOutputNum, ushort wLanguage, [MarshalUsing(CountElementName = nameof(pcchLanguageStringLength))] out PWSTR pwszLanguageString, ref ushort pcchLanguageStringLength);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreaderadvanced4-getmaxspeedfactor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMaxSpeedFactor(out double pdblFactor);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreaderadvanced4-isusingfastcache
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsUsingFastCache(out BOOL pfUsingFastCache);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreaderadvanced4-addlogparam
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddLogParam(PWSTR wszNameSpace, PWSTR wszName, PWSTR wszValue);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreaderadvanced4-sendlogparams
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SendLogParams();
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreaderadvanced4-cansavefileas
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CanSaveFileAs(out BOOL pfCanSave);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreaderadvanced4-cancelsavefileas
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CancelSaveFileAs();
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreaderadvanced4-geturl
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetURL([MarshalUsing(CountElementName = nameof(pcchURL))] out PWSTR pwszURL, ref uint pcchURL);
}
