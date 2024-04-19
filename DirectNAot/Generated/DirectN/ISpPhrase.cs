namespace DirectN;

[GeneratedComInterface, Guid("1a5c0354-b621-4b5a-8791-d306ed379e53")]
public partial interface ISpPhrase
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPhrase(out SPPHRASE ppCoMemPhrase);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSerializedPhrase(out SPSERIALIZEDPHRASE ppCoMemPhrase);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetText(uint ulStart, uint ulCount, [MarshalAs(UnmanagedType.U4)] bool fUseTextReplacements, out PWSTR ppszCoMemText, nint /* byte array */ pbDisplayAttributes);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Discard(uint dwValueTypes);
}
