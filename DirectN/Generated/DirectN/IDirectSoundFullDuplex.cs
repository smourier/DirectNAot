#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("edcb4c7a-daab-4216-a42e-6c50596ddc1d")]
public partial interface IDirectSoundFullDuplex
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize(in Guid pCaptureGuid, in Guid pRenderGuid, in DSCBUFFERDESC lpDscBufferDesc, in DSBUFFERDESC lpDsBufferDesc, HWND hWnd, uint dwLevel, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirectSoundCaptureBuffer8>))] out IDirectSoundCaptureBuffer8 lplpDirectSoundCaptureBuffer8, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirectSoundBuffer8>))] out IDirectSoundBuffer8 lplpDirectSoundBuffer8);
}
