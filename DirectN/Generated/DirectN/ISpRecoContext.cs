#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("f740a62f-7c15-489e-8234-940a33d9272d")]
public partial interface ISpRecoContext : ISpEventSource
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRecognizer([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpRecognizer>))] out ISpRecognizer ppRecognizer);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateGrammar(ulong ullGrammarId, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpRecoGrammar>))] out ISpRecoGrammar ppGrammar);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStatus(ref SPRECOCONTEXTSTATUS pStatus);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMaxAlternates(ref uint pcAlternates);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetMaxAlternates(uint cAlternates);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAudioOptions(SPAUDIOOPTIONS Options, in Guid pAudioFormatId, in WAVEFORMATEX pWaveFormatEx);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAudioOptions(ref SPAUDIOOPTIONS pOptions, ref Guid pAudioFormatId, ref WAVEFORMATEX ppCoMemWFEX);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DeserializeResult(in SPSERIALIZEDRESULT pSerializedResult, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpRecoResult>))] out ISpRecoResult ppResult);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Bookmark(SPBOOKMARKOPTIONS Options, ulong ullStreamPosition, LPARAM lparamEvent);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAdaptationData(PWSTR pAdaptationData, uint cch);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Pause(uint dwReserved);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Resume(uint dwReserved);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetVoice(ISpVoice pVoice, BOOL fAllowFormatChanges);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVoice([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpVoice>))] out ISpVoice ppVoice);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetVoicePurgeEvent(ulong ullEventInterest);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVoicePurgeEvent(ref ulong pullEventInterest);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetContextState(SPCONTEXTSTATE eContextState);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetContextState(ref SPCONTEXTSTATE peContextState);
}
