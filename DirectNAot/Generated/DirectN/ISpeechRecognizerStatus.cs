namespace DirectN;

[GeneratedComInterface, Guid("bff9e781-53ec-484e-bb8a-0e1b5551e35c")]
public partial interface ISpeechRecognizerStatus : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_AudioStatus(out ISpeechAudioStatus AudioStatus);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_CurrentStreamPosition(out VARIANT pCurrentStreamPos);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_CurrentStreamNumber(out int StreamNumber);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_NumberOfActiveRules(out int NumberOfActiveRules);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ClsidEngine(out BSTR ClsidEngine);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_SupportedLanguages(out VARIANT SupportedLanguages);
}
