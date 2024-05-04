#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("903e9878-2c92-4072-9b2c-ea68f5396783")]
public partial interface IDirectSoundFXFlanger
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAllParameters(in DSFXFlanger pcDsFxFlanger);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAllParameters(out DSFXFlanger pDsFxFlanger);
}
