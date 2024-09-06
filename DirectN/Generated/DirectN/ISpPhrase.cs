#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("1a5c0354-b621-4b5a-8791-d306ed379e53")]
public partial interface ISpPhrase
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPhrase(out nint ppCoMemPhrase);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSerializedPhrase(out nint ppCoMemPhrase);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetText(uint ulStart, uint ulCount, BOOL fUseTextReplacements, out PWSTR ppszCoMemText, nint /* optional byte* */ pbDisplayAttributes);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Discard(uint dwValueTypes);
}
