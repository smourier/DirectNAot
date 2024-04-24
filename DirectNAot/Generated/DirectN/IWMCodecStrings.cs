namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nn-wmcodecdsp-iwmcodecstrings
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("a7b2504b-e58a-47fb-958b-cac7165a057d")]
public partial interface IWMCodecStrings
{
    // https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nf-wmcodecdsp-iwmcodecstrings-getname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetName(ref DMO_MEDIA_TYPE pmt, uint cchLength, [MarshalUsing(CountElementName = nameof(cchLength))] out PWSTR[] szName, ref uint pcchLength);
    
    // https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nf-wmcodecdsp-iwmcodecstrings-getdescription
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDescription(ref DMO_MEDIA_TYPE pmt, uint cchLength, [MarshalUsing(CountElementName = nameof(cchLength))] out PWSTR[] szDescription, ref uint pcchLength);
}
