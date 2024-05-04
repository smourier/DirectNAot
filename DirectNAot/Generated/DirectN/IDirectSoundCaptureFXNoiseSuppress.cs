#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("ed311e41-fbae-4175-9625-cd0854f693ca")]
public partial interface IDirectSoundCaptureFXNoiseSuppress
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAllParameters(in DSCFXNoiseSuppress pcDscFxNoiseSuppress);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAllParameters(out DSCFXNoiseSuppress pDscFxNoiseSuppress);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Reset();
}
