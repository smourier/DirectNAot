#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("ce563d48-961e-4732-a2e1-378a42b430be")]
public partial interface ISpeechPhraseProperty : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Name(out BSTR Name);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Id(out int Id);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Value(out VARIANT Value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_FirstElement(out int FirstElement);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_NumberOfElements(out int NumberOfElements);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_EngineConfidence(out float Confidence);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Confidence(out SpeechEngineConfidence Confidence);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Parent([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpeechPhraseProperty>))] out ISpeechPhraseProperty ParentProperty);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Children([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpeechPhraseProperties>))] out ISpeechPhraseProperties Children);
}
