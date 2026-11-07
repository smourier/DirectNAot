#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("6bdf1188-6ec8-44ff-8ccc-bfca0d12afa3")]
public partial interface IMFMediaEngineVideoRendererEffect
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetEffect(nint pEffect);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ClearEffect();
}
