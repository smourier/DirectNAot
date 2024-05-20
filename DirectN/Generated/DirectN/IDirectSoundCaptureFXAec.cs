#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("ad74143d-903d-4ab7-8066-28d363036d65")]
public partial interface IDirectSoundCaptureFXAec
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAllParameters(in DSCFXAec pDscFxAec);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAllParameters(out DSCFXAec pDscFxAec);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStatus(out uint pdwStatus);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Reset();
}
