#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmdrmwriter
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("d6ea5dd0-12a0-43f4-90ab-a3fd451e6a07")]
public partial interface IWMDRMWriter
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmdrmwriter-generatekeyseed
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GenerateKeySeed([MarshalUsing(CountElementName = nameof(pcwchLength))] PWSTR pwszKeySeed, ref uint pcwchLength);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmdrmwriter-generatekeyid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GenerateKeyID([MarshalUsing(CountElementName = nameof(pcwchLength))] PWSTR pwszKeyID, ref uint pcwchLength);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmdrmwriter-generatesigningkeypair
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GenerateSigningKeyPair([MarshalUsing(CountElementName = nameof(pcwchPrivKeyLength))] PWSTR pwszPrivKey, ref uint pcwchPrivKeyLength, [MarshalUsing(CountElementName = nameof(pcwchPubKeyLength))] PWSTR pwszPubKey, ref uint pcwchPubKeyLength);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmdrmwriter-setdrmattribute
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDRMAttribute(ushort wStreamNum, PWSTR pszName, WMT_ATTR_DATATYPE Type, nint /* byte array */ pValue, ushort cbLength);
}
