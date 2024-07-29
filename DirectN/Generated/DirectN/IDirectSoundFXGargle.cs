#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("d616f352-d622-11ce-aac5-0020af0b99a3")]
public partial interface IDirectSoundFXGargle
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAllParameters(in DSFXGargle pcDsFxGargle);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAllParameters(out DSFXGargle pDsFxGargle);
}
