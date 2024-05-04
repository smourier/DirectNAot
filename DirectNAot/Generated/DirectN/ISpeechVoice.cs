#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("269316d8-57bd-11d2-9eee-00c04f797396")]
public partial interface ISpeechVoice : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Status(out ISpeechVoiceStatus Status);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Voice(out ISpeechObjectToken Voice);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT putref_Voice(ISpeechObjectToken? Voice);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_AudioOutput(out ISpeechObjectToken AudioOutput);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT putref_AudioOutput(ISpeechObjectToken? AudioOutput);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_AudioOutputStream(out ISpeechBaseStream AudioOutputStream);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT putref_AudioOutputStream(ISpeechBaseStream? AudioOutputStream);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Rate(out int Rate);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Rate(int Rate);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Volume(out int Volume);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Volume(int Volume);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_AllowAudioOutputFormatChangesOnNextSet(VARIANT_BOOL Allow);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_AllowAudioOutputFormatChangesOnNextSet(out VARIANT_BOOL Allow);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_EventInterests(out SpeechVoiceEvents EventInterestFlags);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_EventInterests(SpeechVoiceEvents EventInterestFlags);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Priority(SpeechVoicePriority Priority);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Priority(out SpeechVoicePriority Priority);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_AlertBoundary(SpeechVoiceEvents Boundary);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_AlertBoundary(out SpeechVoiceEvents Boundary);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_SynchronousSpeakTimeout(int msTimeout);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_SynchronousSpeakTimeout(out int msTimeout);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Speak(BSTR Text, SpeechVoiceSpeakFlags Flags, out int StreamNumber);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SpeakStream(ISpeechBaseStream? Stream, SpeechVoiceSpeakFlags Flags, out int StreamNumber);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Pause();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Resume();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Skip(BSTR Type, int NumItems, out int NumSkipped);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVoices(BSTR RequiredAttributes, BSTR OptionalAttributes, out ISpeechObjectTokens ObjectTokens);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAudioOutputs(BSTR RequiredAttributes, BSTR OptionalAttributes, out ISpeechObjectTokens ObjectTokens);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT WaitUntilDone(int msTimeout, out VARIANT_BOOL Done);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SpeakCompleteEvent(out int Handle);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsUISupported(BSTR TypeOfUI, in VARIANT ExtraData, out VARIANT_BOOL Supported);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DisplayUI(int hWndParent, BSTR Title, BSTR TypeOfUI, in VARIANT ExtraData);
}
