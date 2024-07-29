#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("8ecf4326-455f-4d8b-bda9-8d5d3e9e3e0b")]
public partial interface IDirectSoundFXDistortion
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAllParameters(in DSFXDistortion pcDsFxDistortion);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAllParameters(out DSFXDistortion pDsFxDistortion);
}
