﻿#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("580aa49d-7e1e-4809-b8e2-57da806104b8")]
public partial interface ISpeechRecoContext : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Recognizer([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpeechRecognizer>))] out ISpeechRecognizer Recognizer);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_AudioInputInterferenceStatus(out SpeechInterference Interference);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_RequestedUIType(out BSTR UIType);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT putref_Voice([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpeechVoice?>))] ISpeechVoice? Voice);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Voice([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpeechVoice>))] out ISpeechVoice Voice);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_AllowVoiceFormatMatchingOnNextSet(VARIANT_BOOL Allow);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_AllowVoiceFormatMatchingOnNextSet(out VARIANT_BOOL pAllow);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_VoicePurgeEvent(SpeechRecoEvents EventInterest);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_VoicePurgeEvent(out SpeechRecoEvents EventInterest);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_EventInterests(SpeechRecoEvents EventInterest);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_EventInterests(out SpeechRecoEvents EventInterest);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_CmdMaxAlternates(int MaxAlternates);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_CmdMaxAlternates(out int MaxAlternates);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_State(SpeechRecoContextState State);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_State(out SpeechRecoContextState State);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_RetainedAudio(SpeechRetainedAudioOptions Option);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_RetainedAudio(out SpeechRetainedAudioOptions Option);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT putref_RetainedAudioFormat([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpeechAudioFormat?>))] ISpeechAudioFormat? Format);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_RetainedAudioFormat([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpeechAudioFormat>))] out ISpeechAudioFormat Format);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Pause();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Resume();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateGrammar(VARIANT GrammarId, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpeechRecoGrammar>))] out ISpeechRecoGrammar Grammar);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateResultFromMemory(in VARIANT ResultBlock, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpeechRecoResult>))] out ISpeechRecoResult Result);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Bookmark(SpeechBookmarkOptions Options, VARIANT StreamPos, VARIANT BookmarkId);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAdaptationData(BSTR AdaptationString);
}
