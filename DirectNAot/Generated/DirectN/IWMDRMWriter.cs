﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmdrmwriter
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("d6ea5dd0-12a0-43f4-90ab-a3fd451e6a07")]
public partial interface IWMDRMWriter
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmdrmwriter-generatekeyseed
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GenerateKeySeed(out PWSTR pwszKeySeed, ref uint pcwchLength);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmdrmwriter-generatekeyid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GenerateKeyID(out PWSTR pwszKeyID, ref uint pcwchLength);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmdrmwriter-generatesigningkeypair
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GenerateSigningKeyPair(out PWSTR pwszPrivKey, ref uint pcwchPrivKeyLength, out PWSTR pwszPubKey, ref uint pcwchPubKeyLength);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmdrmwriter-setdrmattribute
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDRMAttribute(ushort wStreamNum, PWSTR pszName, WMT_ATTR_DATATYPE Type, nint /* byte array */ pValue, ushort cbLength);
}