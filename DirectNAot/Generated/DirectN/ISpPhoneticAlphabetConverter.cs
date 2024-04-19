namespace DirectN;

[GeneratedComInterface, Guid("133adcd4-19b4-4020-9fdc-842e78253b17")]
public partial interface ISpPhoneticAlphabetConverter
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLangId(out ushort pLangID);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetLangId(ushort LangID);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SAPI2UPS(in ushort pszSAPIId, out ushort pszUPSId, uint cMaxLength);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UPS2SAPI(in ushort pszUPSId, out ushort pszSAPIId, uint cMaxLength);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMaxConvertLength(uint cSrcLength, [MarshalAs(UnmanagedType.U4)] bool bSAPI2UPS, out uint pcMaxDestLength);
}
