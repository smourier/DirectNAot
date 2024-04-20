namespace DirectN;

[GeneratedComInterface, Guid("6825a449-7524-4d82-920f-50e36ab3ab1e")]
public partial interface IDirectSoundBuffer8 : IDirectSoundBuffer
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFX(uint dwEffectsCount, nint /* optional DSEFFECTDESC */ pDSFXDesc, nint /* optional uint */ pdwResultCodes);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AcquireResources(uint dwFlags, uint dwEffectsCount, out uint pdwResultCodes);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetObjectInPath(in Guid rguidObject, uint dwIndex, in Guid rguidInterface, out nint ppObject);
}
