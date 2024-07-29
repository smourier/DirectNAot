#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("a7bfe112-a4a0-48d9-b602-c313843f6964")]
public partial interface ISpeechPhraseRule : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Name(out BSTR Name);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Id(out int Id);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_FirstElement(out int FirstElement);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_NumberOfElements(out int NumberOfElements);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Parent([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpeechPhraseRule>))] out ISpeechPhraseRule Parent);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Children([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpeechPhraseRules>))] out ISpeechPhraseRules Children);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Confidence(out SpeechEngineConfidence ActualConfidence);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_EngineConfidence(out float EngineConfidence);
}
