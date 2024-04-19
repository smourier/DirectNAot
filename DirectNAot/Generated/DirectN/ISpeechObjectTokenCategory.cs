namespace DirectN;

[GeneratedComInterface, Guid("ca7eac50-2d01-4145-86d4-5ae7d70f4469")]
public partial interface ISpeechObjectTokenCategory : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Id(out BSTR Id);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Default(BSTR TokenId);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Default(out BSTR TokenId);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetId(BSTR Id, VARIANT_BOOL CreateIfNotExist);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDataKey(SpeechDataKeyLocation Location, out ISpeechDataKey DataKey);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumerateTokens(BSTR RequiredAttributes, BSTR OptionalAttributes, out ISpeechObjectTokens Tokens);
}
