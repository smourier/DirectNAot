#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("2890a410-53a7-4fb5-94ec-06d4998e3d02")]
public partial interface ISpeechPhraseReplacement : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_DisplayAttributes(out SpeechDisplayAttributes DisplayAttributes);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Text(out BSTR Text);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_FirstElement(out int FirstElement);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_NumberOfElements(out int NumberOfElements);
}
