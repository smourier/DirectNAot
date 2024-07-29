#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("20b053be-e235-43cd-9a2a-8d17a48b7842")]
public partial interface ISpRecoResult : ISpPhrase
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetResultTimes(ref SPRECORESULTTIMES pTimes);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAlternates(uint ulStartElement, uint cElements, uint ulRequestCount, [In][Out][MarshalUsing(CountElementName = nameof(ulRequestCount))] ISpPhraseAlt[] ppPhrases, ref uint pcPhrasesReturned);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAudio(uint ulStartElement, uint cElements, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpStreamFormat>))] out ISpStreamFormat ppStream);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SpeakAudio(uint ulStartElement, uint cElements, uint dwFlags, ref uint pulStreamNumber);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Serialize(ref SPSERIALIZEDRESULT ppCoMemSerializedResult);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ScaleAudio(in Guid pAudioFormatId, in WAVEFORMATEX pWaveFormatEx);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRecoContext([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpRecoContext>))] out ISpRecoContext ppRecoContext);
}
