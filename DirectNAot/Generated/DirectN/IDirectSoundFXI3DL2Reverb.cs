namespace DirectN;

[GeneratedComInterface, Guid("4b166a6a-0d66-43f3-80e3-ee6280dee1a4")]
public partial interface IDirectSoundFXI3DL2Reverb
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAllParameters(in DSFXI3DL2Reverb pcDsFxI3DL2Reverb);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAllParameters(out DSFXI3DL2Reverb pDsFxI3DL2Reverb);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPreset(uint dwPreset);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPreset(out uint pdwPreset);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetQuality(int lQuality);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetQuality(out int plQuality);
}
