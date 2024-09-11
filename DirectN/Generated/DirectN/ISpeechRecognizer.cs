#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("2d5f1c0c-bd75-4b08-9478-3b11fea2586c")]
public partial interface ISpeechRecognizer : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT putref_Recognizer([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpeechObjectToken?>))] ISpeechObjectToken? Recognizer);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Recognizer([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpeechObjectToken>))] out ISpeechObjectToken Recognizer);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_AllowAudioInputFormatChangesOnNextSet(VARIANT_BOOL Allow);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_AllowAudioInputFormatChangesOnNextSet(out VARIANT_BOOL Allow);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT putref_AudioInput([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpeechObjectToken?>))] ISpeechObjectToken? AudioInput);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_AudioInput([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpeechObjectToken>))] out ISpeechObjectToken AudioInput);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT putref_AudioInputStream([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpeechBaseStream?>))] ISpeechBaseStream? AudioInputStream);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_AudioInputStream([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpeechBaseStream>))] out ISpeechBaseStream AudioInputStream);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_IsShared(out VARIANT_BOOL Shared);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_State(SpeechRecognizerState State);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_State(out SpeechRecognizerState State);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Status([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpeechRecognizerStatus>))] out ISpeechRecognizerStatus Status);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT putref_Profile([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpeechObjectToken?>))] ISpeechObjectToken? Profile);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Profile([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpeechObjectToken>))] out ISpeechObjectToken Profile);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EmulateRecognition(VARIANT TextElements, in VARIANT ElementDisplayAttributes, int LanguageId);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateRecoContext([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpeechRecoContext>))] out ISpeechRecoContext NewContext);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFormat(SpeechFormatType Type, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpeechAudioFormat>))] out ISpeechAudioFormat Format);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPropertyNumber(BSTR Name, int Value, out VARIANT_BOOL Supported);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPropertyNumber(BSTR Name, ref int Value, out VARIANT_BOOL Supported);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPropertyString(BSTR Name, BSTR Value, out VARIANT_BOOL Supported);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPropertyString(BSTR Name, ref BSTR Value, out VARIANT_BOOL Supported);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsUISupported(BSTR TypeOfUI, in VARIANT ExtraData, out VARIANT_BOOL Supported);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DisplayUI(int hWndParent, BSTR Title, BSTR TypeOfUI, in VARIANT ExtraData);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRecognizers(BSTR RequiredAttributes, BSTR OptionalAttributes, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpeechObjectTokens>))] out ISpeechObjectTokens ObjectTokens);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAudioInputs(BSTR RequiredAttributes, BSTR OptionalAttributes, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpeechObjectTokens>))] out ISpeechObjectTokens ObjectTokens);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProfiles(BSTR RequiredAttributes, BSTR OptionalAttributes, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpeechObjectTokens>))] out ISpeechObjectTokens ObjectTokens);
}
