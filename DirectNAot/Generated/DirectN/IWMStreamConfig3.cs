namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmstreamconfig3
[GeneratedComInterface, Guid("cb164104-3aa9-45a7-9ac9-4daee131d6e1")]
public partial interface IWMStreamConfig3 : IWMStreamConfig2
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmstreamconfig3-getlanguage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLanguage(out PWSTR pwszLanguageString, ref ushort pcchLanguageStringLength);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmstreamconfig3-setlanguage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetLanguage(PWSTR pwszLanguageString);
}
