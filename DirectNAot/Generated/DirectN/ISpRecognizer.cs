namespace DirectN;

[GeneratedComInterface, Guid("c2b5f241-daa0-4507-9e16-5a1eaa2b7a5c")]
public partial interface ISpRecognizer : ISpProperties
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRecognizer(ISpObjectToken pRecognizer);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRecognizer(out ISpObjectToken ppRecognizer);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetInput(nint pUnkInput, [MarshalAs(UnmanagedType.U4)] bool fAllowFormatChanges);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetInputObjectToken(out ISpObjectToken ppToken);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetInputStream(out ISpStreamFormat ppStream);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateRecoContext(out ISpRecoContext ppNewCtxt);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRecoProfile(out ISpObjectToken ppToken);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRecoProfile(ISpObjectToken pToken);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsSharedInstance();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRecoState(ref SPRECOSTATE pState);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRecoState(SPRECOSTATE NewState);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStatus(ref SPRECOGNIZERSTATUS pStatus);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFormat(SPSTREAMFORMATTYPE WaveFormatType, ref Guid pFormatId, out WAVEFORMATEX ppCoMemWFEX);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsUISupported(PWSTR pszTypeOfUI, nint pvExtraData, uint cbExtraData, [MarshalAs(UnmanagedType.U4)] ref bool pfSupported);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DisplayUI(HWND hwndParent, PWSTR pszTitle, PWSTR pszTypeOfUI, nint pvExtraData, uint cbExtraData);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EmulateRecognition(ISpPhrase pPhrase);
}
