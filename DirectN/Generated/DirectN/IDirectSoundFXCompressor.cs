#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("4bbd1154-62f6-4e2c-a15c-d3b6c417f7a0")]
public partial interface IDirectSoundFXCompressor
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAllParameters(in DSFXCompressor pcDsFxCompressor);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAllParameters(out DSFXCompressor pDsFxCompressor);
}
