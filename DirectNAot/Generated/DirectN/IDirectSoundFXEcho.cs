namespace DirectN;

[GeneratedComInterface, Guid("8bd28edf-50db-4e92-a2bd-445488d1ed42")]
public partial interface IDirectSoundFXEcho
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAllParameters(in DSFXEcho pcDsFxEcho);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAllParameters(out DSFXEcho pDsFxEcho);
}
