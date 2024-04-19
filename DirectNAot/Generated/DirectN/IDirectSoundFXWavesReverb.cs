namespace DirectN;

[GeneratedComInterface, Guid("46858c3a-0dc6-45e3-b760-d4eef16cb325")]
public partial interface IDirectSoundFXWavesReverb
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAllParameters(in DSFXWavesReverb pcDsFxWavesReverb);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAllParameters(out DSFXWavesReverb pDsFxWavesReverb);
}
