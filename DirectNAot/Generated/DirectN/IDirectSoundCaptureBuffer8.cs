namespace DirectN;

[GeneratedComInterface, Guid("00990df4-0dbb-4872-833e-6d303e80aeb6")]
public partial interface IDirectSoundCaptureBuffer8 : IDirectSoundCaptureBuffer
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetObjectInPath(in Guid rguidObject, uint dwIndex, in Guid rguidInterface, out nint ppObject);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFXStatus(uint dwEffectsCount, out uint pdwFXStatus);
}
